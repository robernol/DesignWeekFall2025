using UnityEngine;

public class TimerSpawner : MonoBehaviour
{
    public GameObject timerPrefab;

    void Start()
    {
        if (GlobalVariableManager.timerShouldBeActive)
        {
           
                GameObject newTimer = Instantiate(timerPrefab);

                Debug.Log("Time");
                
                DontDestroyOnLoad(newTimer);

                
            

            GlobalVariableManager.timerShouldBeActive = false; // clear flag
        }
    }
}
