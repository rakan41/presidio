import logging
from typing import List

from presidio_anonymizer.entities.manipulator.manipulated_result_item import \
    ManipulatedResultItem
from presidio_anonymizer.entities.manipulator.manipulator_result import \
    ManipulatorResult
from presidio_anonymizer.entities.manipulator.text_manipulation_item import \
    TextManipulationItem
from presidio_anonymizer.services.text_builder import TextBuilder


class TextManipulator:
    logger = logging.getLogger("presidio-anonymizer")

    def manipulate_text(self, text: str,
                        manipulations: List[TextManipulationItem]) -> ManipulatorResult:
        text_builder = TextBuilder(original_text=text)
        manipulation_result = ManipulatorResult()
        for manipulation in sorted(manipulations, reverse=True):
            text_to_manipulate = text_builder.get_text_in_position(
                manipulation.start, manipulation.end
            )

            self.logger.debug(
                f"performing manipulation {manipulation}"
            )

            manipulated_text = self.__manipulate_text(
                manipulation, text_to_manipulate
            )
            index_from_end = text_builder.replace_text_get_insertion_index(
                manipulated_text, manipulation.start, manipulation.end
            )

            # The following creates an intermediate list of anonymized entities,
            # ordered from end to start, and the indexes will be normalized
            # from start to end once the loop ends and the text length is deterministic.
            result_item = ManipulatedResultItem(
                manipulator=manipulation.manipulator_class().operator_name(),
                entity_type=manipulation.entity_type,
                start=0,
                end=index_from_end,
                manipulated_text=manipulated_text,
            )

            manipulation_result.add_item(result_item)

        manipulation_result.set_text(text_builder.output_text)
        manipulation_result.normalize_item_indexes()
        return manipulation_result

    def __manipulate_text(
            self,
            manipulator_entity: TextManipulationItem,
            text_to_manipulate: str,
    ) -> str:
        entity_type = manipulator_entity.entity_type
        self.logger.debug(f"getting operator for {entity_type}")
        operator = manipulator_entity.manipulator_class()
        self.logger.debug(f"validating operator {operator} for {entity_type}")
        operator.validate(params=manipulator_entity.params)
        params = manipulator_entity.params
        params["entity_type"] = entity_type
        self.logger.debug(f"operating on {entity_type} with {operator}")
        anonymized_text = operator.operate(params=params, text=text_to_manipulate)
        return anonymized_text