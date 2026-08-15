using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 moveInput;
    [SerializeField] private float moveSpeed = 6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        if (rb != null)
        {
            moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
