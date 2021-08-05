from presidio_image_redactor import ImageRedactorEngine
from tests.integration.methods import get_resource_image, compare_images

red_fill = (255, 0, 0)


def test_given_image_with_text_and_fill_then_text_is_greyed_out():
    # Image with PII entities
    image = get_resource_image("ocr_test.png")
    result_image = get_resource_image("ocr_test_redacted.png")
    redacted_image = ImageRedactorEngine().redact(image, 1)
    assert compare_images(redacted_image, result_image)


def test_given_image_with_text_and_matrix_fill_then_text_is_colored_out():
    # Image with PII entities
    image = get_resource_image("ocr_test.png")

    redacted_image = ImageRedactorEngine().redact(image, red_fill)
    expected_result_image = get_resource_image("ocr_test_redacted_matrix.png")
    assert compare_images(redacted_image, expected_result_image)
    assert not compare_images(redacted_image, image)


def test_given_image_without_text_and_fill_then_image_does_not_change():
    # Image without PII entities
    image = get_resource_image("no_ocr.jpg")
    redacted_image = ImageRedactorEngine().redact(image, red_fill)
    assert compare_images(redacted_image, image)

def test_that_kwargs_work_for_redact_method():
    """
    Tests that kwargs such as entities and score_threshold are available for redact method
    """
    # Image with PII entities 
    image = get_resource_image("kwargs_test.jpg")
    redacted_image_no_args = ImageRedactorEngine().redact(image)
    redacted_image_entities_args = ImageRedactorEngine().redact(image, entities=['PERSON', 'LOCATION'])
    redacted_image_score_args = ImageRedactorEngine().redact(image, score_threshold=1)
    assert not compare_images(redacted_image_no_args, redacted_image_entities_args)
    assert not compare_images(redacted_image_no_args, redacted_image_score_args)
    assert not compare_images(redacted_image_entities_args, redacted_image_score_args)
