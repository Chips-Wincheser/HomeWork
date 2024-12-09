using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;

    private int _counter = 0;
    private float _waitNumber = 0.5f;

    public void StartCounting()
    {
        StartCoroutine(Count());
    }

    public void StopCounting()
    {
        StopCoroutine(Count());
    }

    private IEnumerator Count()
    {
        while (true)
        {
            yield return new WaitForSeconds(_waitNumber);
            _counter++;

            if (_counterText != null)
            {
                _counterText.text ="" + _counter;
            }
        }
    }
}
