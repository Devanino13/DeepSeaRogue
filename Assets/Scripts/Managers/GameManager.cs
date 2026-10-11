using UnityEngine;

namespace Nekton
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        public int totalFragments = 0;
        public string currentZone = "Coral Expanse";

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void AddFragments(int amount)
        {
            totalFragments += amount;
            Debug.Log("Fragments collected: " + totalFragments);
        }

        public void SetZone(string zoneName)
        {
            currentZone = zoneName;
            Debug.Log("Player entered: " + currentZone);
        }
    }
}
