using UnityEngine;

public class playerRotation : MonoBehaviour
{
    public float rotationSpeed = 100f; // Adjust for desired rotation speed
    private Vector3 mouseDelta;
    private Vector3 currentRotation;
    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.localRotation;
    }

    void Update()
    {
        // Check if the right mouse button is pressed
        if (Input.GetMouseButton(1))
        {
            // Get mouse delta
            mouseDelta = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);

            // Rotate the player around the Y axis (horizontal rotation)
            float horizontalRotation = mouseDelta.x * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, horizontalRotation, Space.World);

            //You can add a vertical rotation if you're using a camera follow script.
            //For example, you can have the camera rotate around the character.
            //float verticalRotation = mouseDelta.y * rotationSpeed * Time.deltaTime;
            //transform.Rotate(Vector3.right, -verticalRotation, Space.World);
        }
    }
}
