using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTesting : MonoBehaviour
{

    public void LoadPuzzleScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
