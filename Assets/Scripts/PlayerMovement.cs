using UnityEngine;

namespace ZombieEscape
{
    public class PlayerMovement : MonoBehaviour
    {
        public float walkSpeed = 5f;
        public float runSpeed = 10f;
        private CharacterController controller;
        
        void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        void Update()
        {
            HandleMovement();
        }

        void HandleMovement()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 move = transform.right * horizontal + transform.forward * vertical;

            float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;

            controller.Move(move * currentSpeed * Time.deltaTime);
        }
    }
}