using UnityEngine;

public class FlyCamera : MonoBehaviour
{
    public float moveSpeed = 10f;       // Speed of camera movement
    public float lookSpeed = 2f;        // Speed of camera rotation
    public float sprintMultiplier = 2f; // Speed multiplier when sprinting

    private float yaw = 0f;
    private float pitch = 0f;

    void Start()
    {
        // Lock and hide the cursor to improve control
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Adjust camera rotation based on mouse movement
        yaw += lookSpeed * Input.GetAxis("Mouse X");
        pitch -= lookSpeed * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -90f, 90f); // Limit pitch to prevent flipping

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        // Adjust movement speed if holding down shift (sprint)
        float currentSpeed = moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed *= sprintMultiplier;
        }

        // Move the camera based on WASD or arrow key input
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(moveDirection * currentSpeed * Time.deltaTime);

        // Move up or down with Q and E keys
        if (Input.GetKey(KeyCode.Q)) transform.Translate(Vector3.down * currentSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.E)) transform.Translate(Vector3.up * currentSpeed * Time.deltaTime);

        // Press Escape to unlock and show the cursor
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}