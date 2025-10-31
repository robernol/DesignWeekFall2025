using UnityEngine;

public class WinScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject timerCanvas = GameObject.Find("TimerCanvas"); 
        GameObject timerManager = GameObject.Find("TimerManager"); 
        if (timerCanvas != null && timerManager)
        {
            Destroy(timerCanvas);
            Destroy(timerManager);
        }
    }
}
