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
    public float rightLimit;
    public float leftLimit;
    public float minSpeed;
    public float maxSpeed;
    [HideInInspector] public float pointerSpeed;
    private int direction;


    private void Start()
    {
        GoalBarRandomnizer();
        pointerSpeed = Random.Range(minSpeed, maxSpeed);
        Debug.Log($"Pointer Speed : {pointerSpeed}");
        direction = 1;
    }
    private void Update()
    {
        PointerMovement();
        // replace with PlayerInput.leftIsPressed (or the other button)
        if (Input.GetKeyDown(KeyCode.S))
        {
            pointerSpeed = 0;
            EvaluatePointerStopBounds();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GoalBarRandomnizer();
        }
    }

    private void GoalBarRandomnizer()
    {
        float randomX = Random.Range(-5.11f, 5.13f);
        float randomWidth = Random.Range(1.0f, 4f);
        goalPos = new Vector2(randomX, goalBar.transform.position.y);
        goalBar.transform.localScale = new Vector2(randomWidth, goalBar.transform.localScale.y);
        goalBar.transform.position = goalPos;
    }
    private void PointerMovement()
    {
        Vector2 pos = pointer.transform.position;
        pos.x += pointerSpeed * direction * Time.deltaTime;
        pointer.transform.position = pos;

        if(pos.x >=  rightLimit)
        {
            pos.x = rightLimit;
            direction = -1;
        }else if(pos.x <= leftLimit)
        {
            pos.x = leftLimit;
            direction = 1;
        }

        pointer.transform.position = pos;
    }
    public void EvaluatePointerStopBounds()
    {
        SpriteRenderer goalBarSR = goalBar.GetComponent<SpriteRenderer>();
        if (goalBarSR == null)
        {
            Debug.LogWarning("GoalBar needs a SpriteRenderer for bounds check.");
            return;
        }

        Vector2 pointerPosWithOffset = new Vector2(pointer.transform.position.x, 0);
        if (goalBarSR.bounds.Contains(pointerPosWithOffset))
        {
            OnPointerEnterGoal();
        } else
        {
            OnPointerExitGoal();
        }
    }

    public void OnPointerEnterGoal()
    {
        Debug.Log("Pointer is in goal!");
        // do stuff if player success
    }

    public void OnPointerExitGoal()
    {
        Debug.Log("Pointer is Not in goal!");
        // do stuff if player fails
    }
}
