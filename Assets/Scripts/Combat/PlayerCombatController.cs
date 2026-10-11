using UnityEngine;

namespace Nekton
{
    public class PlayerCombatController : MonoBehaviour
    {
        [Header("Combat")]
        public GameObject projectilePrefab;
        public float fireRate = 0.25f;
        public float projectileSpeed = 12f;

        private float fireCooldown;

        private void Update()
        {
            fireCooldown -= Time.deltaTime;

            if (Input.GetMouseButton(0) && fireCooldown <= 0f)
            {
                Shoot();
                fireCooldown = fireRate;
            }
        }

        private void Shoot()
        {
            if (projectilePrefab == null)
            {
                Debug.LogWarning("Projectile prefab is missing.");
                return;
            }

            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 0f;

            Vector2 direction = (mouseWorldPosition - transform.position).normalized;
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                rb.velocity = direction * projectileSpeed;
            }
        }
    }
}
