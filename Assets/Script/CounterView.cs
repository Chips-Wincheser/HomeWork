using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private Counter _counter;

    private const string ÑountCoroutine = "Count";

    private bool _isCounting = false;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting)
            {
                _counter.StopCoroutine(ÑountCoroutine);
            }
            else
            {
                _counter.StartCoroutine(ÑountCoroutine);
            }
            _isCounting = !_isCounting;
        }
    }
}
