using UnityEngine;

public class MovingBatScript : MonoBehaviour
{
    [Header("Bar References")]
    public GameObject bar;

    [Header("Goal References")]
    public GameObject goalBar;
    private Vector2 goalPos; 

    [Header("Pointer")]
    public GameObject pointer;


    private void Start()
    {
        GoalBarRandomnizer();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GoalBarRandomnizer();
        }
    }

    private void GoalBarRandomnizer()
    {
        float randomX = Random.Range(-5.11f, 5.13f);
        float randomWidth = Random.Range(1.0f, 3.5f);
        goalPos = new Vector2(randomX, goalBar.transform.position.y);
        goalBar.transform.localScale = new Vector2(bar.transform.localScale.x, goalBar.transform.localScale.y);
        goalBar.transform.position = goalPos;
    }
}
