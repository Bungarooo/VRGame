using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float mouseSensitivity = 2.0f;

    private CharacterController characterController;
    private Transform cameraTransform;
    private Vector3 moveDirection = Vector3.zero;
    private float rotationY = 0.0f;

    private void Awake()
    {
        characterController = gameObject.AddComponent<CharacterController>();
        cameraTransform = new GameObject("Camera").transform;
        cameraTransform.parent = transform;

        Camera camera = cameraTransform.gameObject.AddComponent<Camera>();
        camera.clearFlags = CameraClearFlags.SolidColor;
    }

    private void Start()
    {
        cameraTransform.localPosition = new Vector3(0, 1, -5);
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");

        moveDirection = (horizontal * transform.right + vertical * transform.forward).normalized * speed * Time.deltaTime;
        characterController.Move(moveDirection);

        rotationY += mouseX * mouseSensitivity;
        transform.localEulerAngles = new Vector3(0, rotationY, 0);
    }
}
