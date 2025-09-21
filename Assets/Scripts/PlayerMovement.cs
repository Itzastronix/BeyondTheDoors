using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float mouseSenstivity;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        float Moveforward = Input.GetAxis("Vertical");
        float MoveRight = Input.GetAxis("Horizontal");

        Vector3 moveDir = (transform.forward * Moveforward + transform.right * MoveRight).normalized;
        rb.linearVelocity = moveDir * playerSpeed + new Vector3(0, rb.linearVelocity.y, 0);

        float xRotation = Input.GetAxis("Mouse X") * mouseSenstivity * Time.deltaTime;
        float yRotation = Input.GetAxis("Mouse Y") * mouseSenstivity * Time.deltaTime;

    }
    
}
