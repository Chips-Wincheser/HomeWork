using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;

    private const string ÑountCoroutine = "Count";

    private int _counter = 0;
    private bool _isCounting = false;
    private float WaitNumber = 0.5f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting)
            {
                StopCoroutine(ÑountCoroutine);
            }
            else
            {
                StartCoroutine(ÑountCoroutine);
            }
            _isCounting = !_isCounting;
        }
    }

    private IEnumerator Count()
    {
        while (true)
        {
            yield return new WaitForSeconds(WaitNumber);
            _counter++;

            if (_counterText != null)
            {
                _counterText.text ="" + _counter;
            }
        }
    }
}
