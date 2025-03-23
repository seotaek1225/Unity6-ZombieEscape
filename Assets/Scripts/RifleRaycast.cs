using UnityEngine;

namespace ZombieEscape
{
    public class RifleRaycast : MonoBehaviour
    {
        private RifleEffect effect;
        
        public float damage = 10f;
        public float range = 100f;
        public float fireRate = 15f;
        public float impactForce = 30f;

        public Camera fpsCamera;
        private float nextTimeToFire = 0f;

        public AudioSource shootSound;

        void Awake()
        {
            effect = GetComponent<RifleEffect>();
        }

        void Update()
        {
            if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                shoot();
            }
        }

        private void shoot()
        {
            shootSound.Play();

            RaycastHit hit;
            if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
            {
                Debug.DrawLine(fpsCamera.transform.position, hit.point, Color.red, 1.0f);

                ZombieEnemey target = hit.transform.GetComponent<ZombieEnemey>();
                if (target != null)
                {
                    target.TakeDamage(damage);
                }

                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * impactForce);
                }

                effect.ShootEffect(hit);
            }
        }
    }
}