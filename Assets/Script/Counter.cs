using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    private int _counter = 0;
    private bool _isCounting = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting)
            {
                StopCoroutine("Count");
            }
            else
            {
                StartCoroutine("Count");
            }
            _isCounting = !_isCounting;
        }
    }

    private IEnumerator Count()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            _counter++;

            if (_counterText != null)
            {
                _counterText.text ="" + _counter;
            }
        }
    }
}
