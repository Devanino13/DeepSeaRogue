using UnityEngine;

namespace Nekton
{
    public class ProceduralRoomGenerator : MonoBehaviour
    {
        [Header("Room generation")]
        public GameObject[] enemyPrefabs;
        public int enemyCount = 5;
        public Vector2 roomCenter = Vector2.zero;
        public float spawnRadius = 4f;

        private void Start()
        {
            GenerateRoom();
        }

        private void GenerateRoom()
        {
            for (int i = 0; i < enemyCount; i++)
            {
                if (enemyPrefabs == null || enemyPrefabs.Length == 0)
                {
                    Debug.LogWarning("No enemy prefabs assigned to the room generator.");
                    return;
                }

                int randomIndex = Random.Range(0, enemyPrefabs.Length);
                Vector2 randomOffset = Random.insideUnitCircle * spawnRadius;
                Vector3 spawnPoint = new Vector3(roomCenter.x + randomOffset.x, roomCenter.y + randomOffset.y, 0f);

                Instantiate(enemyPrefabs[randomIndex], spawnPoint, Quaternion.identity);
            }
        }
    }
}
