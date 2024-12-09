using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private Counter _counter;

    private const string �ountCoroutine = "Count";

    private bool _isCounting = false;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting)
            {
                _counter.StopCoroutine(�ountCoroutine);
            }
            else
            {
                _counter.StartCoroutine(�ountCoroutine);
            }
            _isCounting = !_isCounting;
        }
    }
}
