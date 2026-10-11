using UnityEngine;

namespace Nekton
{
    public class ZoneTrigger : MonoBehaviour
    {
        public string zoneName = "Coral Expanse";

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                GameManager.Instance.SetZone(zoneName);
            }
        }
    }
}
