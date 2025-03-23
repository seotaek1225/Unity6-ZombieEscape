using UnityEngine;

namespace ZombieEscape
{
    public class Rifle : MonoBehaviour
    {
        public RifleEffect effect;
        public RifleRaycast raycast;

        public int bulletTotal = 600;
        public int bulletCurrent = 600;

        private void Awake()
        {
            effect = GetComponent<RifleEffect>();
            raycast = GetComponent<RifleRaycast>();
        }
    }
}