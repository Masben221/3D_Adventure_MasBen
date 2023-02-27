using UnityEngine;
using UnityEngine.UI;

public class UIKeyText : MonoBehaviour
{
    [SerializeField] private Bag _bag;
    [SerializeField] private Text _text;

    private void Start()
    {
        _bag.ChangeAmountKey.AddListener(OnChangeHitPoints);
    }
    private void OnDestroy()
    {
        _bag.ChangeAmountKey.RemoveListener(OnChangeHitPoints);
    }

    private void OnChangeHitPoints()
    {
        _text.text = _bag.GetAmountKey().ToString();
    }
}
