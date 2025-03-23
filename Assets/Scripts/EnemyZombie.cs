using UnityEngine;


namespace ZombieEscape
{
    public class ZombieEnemey : MonoBehaviour
    {
        public float health = 200f;

        public void TakeDamage(float amount)
        {
            health -= amount;
            if (health <= 0f)
            {
                die();
            }
        }

        private void die()
        {
            Destroy(gameObject);
        }
    }
}