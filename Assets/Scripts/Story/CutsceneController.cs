using System.Collections;
using UnityEngine;

namespace Nekton
{
    public class CutsceneController : MonoBehaviour
    {
        [TextArea(3, 8)]
        public string[] cutsceneLines;

        public float lineDisplayTime = 2.5f;
        public bool autoStartOnAwake = true;

        private void Start()
        {
            if (autoStartOnAwake)
            {
                StartCoroutine(PlayCutscene());
            }
        }

        private IEnumerator PlayCutscene()
        {
            foreach (string line in cutsceneLines)
            {
                Debug.Log(line);
                yield return new WaitForSeconds(lineDisplayTime);
            }
        }
    }
}
