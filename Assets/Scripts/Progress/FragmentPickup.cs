using System.Collections.Generic;
using UnityEngine;

namespace Nekton
{
    public class FragmentPickup : MonoBehaviour
    {
        public int fragmentValue = 1;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                GameManager.Instance.AddFragments(fragmentValue);
                Destroy(gameObject);
            }
        }
    }
}
