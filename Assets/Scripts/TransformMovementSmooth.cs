using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovementSmooth : MonoBehaviour
{
    [SerializeField]
    private float _MoveSpeed = 3.5f;

    [SerializeField]
    private float _TurnSpeed = 30.0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.position += Time.deltaTime * _MoveSpeed * transform.right;

        if (Input.GetKey(KeyCode.A))
            transform.position += Time.deltaTime * _MoveSpeed * -transform.right;

        if (Input.GetKey(KeyCode.W))
            transform.position += Time.deltaTime * _MoveSpeed * transform.forward;

        if (Input.GetKey(KeyCode.S))
            transform.position += Time.deltaTime * _MoveSpeed * -transform.forward;

        if (Input.GetKey(KeyCode.Space))
            transform.position = new Vector3(0, 1f, 0);

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Time.deltaTime * _TurnSpeed * Vector3.down);

        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Time.deltaTime * _TurnSpeed * Vector3.up);
    }
}
