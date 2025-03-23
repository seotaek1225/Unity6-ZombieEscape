using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace ZombieEscape
{
    public class RifleEffect : MonoBehaviour
    {
        public Crosshair crosshair;

        public GameObject impactEffect;
        public GameObject bulletHole;
        
        public void ShootEffect(RaycastHit hit)
        {
            if (hit.transform.CompareTag("Enemy") == true)
            {
                crosshair.OnTargetHit();

                GameObject impact = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impact, 2f);
            }

            if (hit.transform.CompareTag("Floor") == true)
            {
                GameObject hole = Instantiate(bulletHole, hit.point, Quaternion.LookRotation(hit.normal));
                hole.transform.SetParent(hit.transform);
                Destroy(hole, 5f);
            }
        }
    }
}