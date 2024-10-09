using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _scaleChange = new Vector3(1, 1, 1);

    private void Update()
    {
        transform.localScale += _scaleChange* _speed*Time.deltaTime;
    }
}