using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody RB;

    public float speed;

    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 Move = transform.right * Horizontal * speed + transform.forward * Vertical * speed;
        Vector3 NewMovePosition = new Vector3(Move.x, RB.velocity.y, Move.z);

        RB.velocity = NewMovePosition;
    }
}
