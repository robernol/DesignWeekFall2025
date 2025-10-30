using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    [Header("Timer Settings")]
    public TextMeshProUGUI minText;
    public TextMeshProUGUI secText;
    public int startingMinutes;
    public int startingSeconds;

    private float countdownTime;
    private bool isCountingDown = true;    

    private void Start()
    {
        countdownTime = startingMinutes * 60 + startingSeconds;
    }

    private void Update()
    {
        if(!isCountingDown) return;

        if(countdownTime > 0)
        {
            countdownTime -= Time.deltaTime;
            UpdateTimeDisplay();
        }
        else
        {
            countdownTime = 0;
            isCountingDown = false;
            UpdateTimeDisplay();
            // Timer has finished, add additional logic here: lose condition
            GlobalVariableManager.timeIsDone = true;
        }

    }

    private void UpdateTimeDisplay()
    {
        int minutes = Mathf.FloorToInt(countdownTime / 60);
        int seconds = Mathf.FloorToInt(countdownTime % 60);

        minText.text = minutes.ToString("00");
        secText.text = seconds.ToString("00");
    }
}
