from presidio_anonymizer.entities.engine.result.anonymize_result_item import \
    AnonymizeResultItem
from presidio_anonymizer.entities.engine.result.engine_result import \
    EngineResult


def test_when_no_params_then_object_initialised_correctly():
    res = EngineResult()
    assert res.text is None
    assert res.items == []


def test_when_correct_params_then_object_initialised_correctly():
    ari = AnonymizeResultItem(0, 35, "text", "type", "hash")
    res = EngineResult("a", [ari])
    assert res.text == "a"
    assert res.items[0] == ari


def test_when_normalized_items_called_then_idexes_are_normalized():
    ari = AnonymizeResultItem(1, 2, "cd", "type", "hash")
    res = EngineResult("*****", [ari])
    res.normalize_item_indexes()
    assert res.items[0].start == 3
    assert res.items[0].end == 5


def test_when_set_text_then_text_is_set():
    res = EngineResult()
    res.set_text("a")
    assert res.text == "a"


def test_when_add_item_the_item_added():
    res = EngineResult()
    ari = AnonymizeResultItem(0, 35, "text", "type", "hash")
    res.add_item(ari)
    assert res.items[0] == ari


def test_when_eq_called_then_instances_are_equal():
    res = EngineResult()
    res.set_text("a")
    res2 = EngineResult()
    res2.set_text("a")

    assert res.__eq__(res2)


def test_when_not_eq_called_then_instances_are_not_equal():
    res = EngineResult()
    res.set_text("a")
    res2 = EngineResult()
    res2.set_text("b")

    assert res.__eq__(res2) is False