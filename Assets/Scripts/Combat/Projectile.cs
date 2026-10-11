using UnityEngine;

namespace Nekton
{
    public class Projectile : MonoBehaviour
    {
        public float lifetime = 2f;
        public int damage = 1;

        private void Start()
        {
            Destroy(gameObject, lifetime);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Destroy(collision.gameObject);
            }

            Destroy(gameObject);
        }
    }
}
