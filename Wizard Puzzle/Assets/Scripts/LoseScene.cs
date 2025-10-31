using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene : MonoBehaviour
{
    void Start()
    {
        GameObject persistentRoot = GameObject.Find("PersistentObjectsParent");
        if (persistentRoot != null)
        {
            Transform timerCanvas = persistentRoot.transform.Find("TimerCanvas");
            Transform timerManager = persistentRoot.transform.Find("TimerManager");

            if (timerCanvas != null) Destroy(timerCanvas.gameObject);
            if (timerManager != null) Destroy(timerManager.gameObject);

            Debug.Log("Destroyed Timer objects inside PersistentObjectsParent");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            // Playerinput.B4
            Debug.Log("restart");
            RestartGameButton();
        }
    }

    public void RestartGameButton()
    {
        GlobalVariableManager.solvedPuzzle1 = false;
        GlobalVariableManager.solvedPuzzle2 = false;
        GlobalVariableManager.solvedPuzzle3 = false;
        GlobalVariableManager.solvedPuzzle4 = false;
        GlobalVariableManager.solvedPuzzle5 = false;
        GlobalVariableManager.solvedPuzzle6 = false;

        SceneManager.LoadScene("Scene1");
    }
}
