using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float _speed = 0.5f;

    private void Update()
    {
        transform.Translate(Vector3.forward*_speed*Time.deltaTime);
    }
}