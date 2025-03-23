using UnityEngine;

namespace ZombieEscape
{
    public class PlayerSingleton : Singleton<PlayerSingleton>
    {
        private PlayerMovement movement;
        private PlayerMouseLook mouseLook;

        protected override void Awake()
        {
            base.Awake();

            movement = GetComponent<PlayerMovement>();
            mouseLook = GetComponent<PlayerMouseLook>();
        }
    }
}