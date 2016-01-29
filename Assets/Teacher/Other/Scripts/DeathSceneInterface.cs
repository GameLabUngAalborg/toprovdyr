using UnityEngine;
using System.Collections;

namespace Teacher
{
    public class DeathSceneInterface : MonoBehaviour
    {

        public void LoadLevel()
        {
            // Loader scenen med index 0
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
