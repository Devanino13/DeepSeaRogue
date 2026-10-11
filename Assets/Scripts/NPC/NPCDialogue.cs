using UnityEngine;

namespace Nekton
{
    public class NPCDialogue : MonoBehaviour
    {
        [TextArea(2, 6)]
        public string[] dialogueLines;

        public string npcName = "NPC";
        public KeyCode interactKey = KeyCode.E;

        private bool playerNearby;
        private int currentIndex;

        private void Update()
        {
            if (playerNearby && Input.GetKeyDown(interactKey))
            {
                ShowNextLine();
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                playerNearby = true;
                Debug.Log(npcName + " is ready to talk.");
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                playerNearby = false;
                currentIndex = 0;
                Debug.Log("Conversation ended.");
            }
        }

        private void ShowNextLine()
        {
            if (dialogueLines == null || dialogueLines.Length == 0)
            {
                return;
            }

            Debug.Log(npcName + ": " + dialogueLines[currentIndex]);
            currentIndex = (currentIndex + 1) % dialogueLines.Length;
        }
    }
}
