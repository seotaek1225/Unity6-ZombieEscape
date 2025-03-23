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
            handleMovement();
        }

        private void handleMovement()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            //Vector3 moveDirection = transform.right * horizontal + transform.forward * vertical;
            Vector3 moveDirection = new Vector3(horizontal, 0f, vertical);
            if (moveDirection.magnitude > 0)
            {
                moveDirection.Normalize();
            }

            float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;

            controller.Move(moveDirection * currentSpeed * Time.deltaTime);
        }
    }
}