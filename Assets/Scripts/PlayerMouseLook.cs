using UnityEngine;

namespace ZombieEscape
{
    public class PlayerMouseLook : MonoBehaviour
    {
        public float mouseSensitivity = 2f;
        public float lookUpLimit = 90f;
        public float lookDownLimit = -90f;
        private Camera playerCamera;
        private float verticalRotation = 0f;

        private void Awake()
        {
            playerCamera = GetComponentInChildren<Camera>();
        }

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void Update()
        {
            handleMouseLook();
        }

        void handleMouseLook()
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

            transform.Rotate(Vector3.up * mouseX);

            verticalRotation -= mouseY;

            verticalRotation = Mathf.Clamp(verticalRotation, lookDownLimit, lookUpLimit);

            playerCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
        }
    }
}