using System.Timers;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 moveInput;
    private float moveSpeed = 10f;
    public float changeDirectionInterval = 2f; // Time in seconds to change direction
    public float actualSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        moveInput = new Vector3(Random.Range(0, 2), Random.Range(0, 2), 0);
        rb.maxLinearVelocity = 100f;
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
        actualSpeed = rb.linearVelocity.magnitude;
    }
}
