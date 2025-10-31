using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene : MonoBehaviour
{
    void Start()
    {
        GameObject persistentRoot = GameObject.Find("PersistentObjectsParent");
        if (persistentRoot != null)
        {
            Transform timerCanvas = persistentRoot.transform.Find("Timer");
            //Transform timerManager = persistentRoot.transform.Find("TimerManager");

            if (timerCanvas != null) Destroy(timerCanvas.gameObject);
          //  if (timerManager != null) Destroy(timerManager.gameObject);

            
        }

        GameObject timer = GameObject.Find("Timer(Clone)");
        if (timer != null)
        {

             Destroy(timer.gameObject);

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            // Playerinput.B4
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

        GlobalVariableManager.timeIsDone = false;
        GlobalVariableManager.timerShouldBeActive = true; // tell Scene1 to spawn the timer again

        SceneManager.LoadScene("Scene1");
    }
}
