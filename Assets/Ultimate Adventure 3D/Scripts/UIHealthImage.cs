using UnityEngine;
using UnityEngine.UI;

public class UIHealthImage : MonoBehaviour
{
    [SerializeField] private Destructible _destructible;
    [SerializeField] private Image _image;

    private void Start()
    {
        _destructible.ChangeHitPoints.AddListener(OnChangeHitPoints);
    }
    private void OnDestroy()
    {
        _destructible.ChangeHitPoints.RemoveListener(OnChangeHitPoints);
    }

    private void OnChangeHitPoints()
    {
        _image.fillAmount = (float) _destructible.GetHitPoints() / (float) _destructible.GetMaxHitPoints();
    }
}
