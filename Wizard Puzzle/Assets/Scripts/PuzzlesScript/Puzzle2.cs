using TMPro;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    [Header("Puzzle 2 Text References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI puzzleNum;
    public GameObject instruction;
    public GameObject hint;

    [Header("Bar References")]
    public GameObject bar;

    [Header("Goal References")]
    public GameObject goalBar;
    public float maxX;
    public float minX;
    public float minWid;
    public float maxWid;

    [Header("Pointer")]
    public GameObject pointer;
    public float rightLimit;
    public float leftLimit;
    public float minSpeed;
    public float maxSpeed;
    public float offset;
    [HideInInspector] public float pointerSpeed;
    private int direction;
    private float oriSpeed;


    private void Start()
    {
        instruction.SetActive(false);
        hint.SetActive(false);

        if (GlobalVariableManager.solvedPuzzle1)
        {
            ShowTranslatedText(puzzleNum, normalFontAsset, puzzleNum.fontSize, 2.ToString());
            instruction.SetActive(true);
        }

        GoalBarRandomnizer();
        pointerSpeed = Random.Range(minSpeed, maxSpeed);
        oriSpeed = pointerSpeed;
        direction = 1;
    }

    private void Update()
    {
        PointerMovement();

        // replace with PlayerInput.button 
        if (Input.GetKeyDown(KeyCode.S))
        {
            pointerSpeed = 0;
            EvaluatePointerStopBounds();
        }
    }

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }

    #region Moving Bar Logic
    private void GoalBarRandomnizer()
    {
        float randomWidth = Random.Range(minWid, maxWid);

        // Compute the half-width (since position is at the center)
        float halfWidth = randomWidth / 2f;

        // Pick a random center position that keeps both edges within minX and maxX
        float randomX = Random.Range(minX + halfWidth, maxX - halfWidth);

        // Apply the new position and scale
        goalBar.transform.localScale = new Vector2(randomWidth, goalBar.transform.localScale.y);
        goalBar.transform.position = new Vector2(randomX, goalBar.transform.position.y);
        //goalBar.transform.position = goalPos;
    }
    private void PointerMovement()
    {
        Vector2 pos = pointer.transform.position;
        pos.x += pointerSpeed * direction * Time.deltaTime;
        pointer.transform.position = pos;

        if (pos.x >= rightLimit)
        {
            pos.x = rightLimit;
            direction = -1;
        }
        else if (pos.x <= leftLimit)
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

        Vector2 pointerPosWithOffset = new Vector2(pointer.transform.position.x, pointer.transform.position.y - offset);
        if (goalBarSR.bounds.Contains(pointerPosWithOffset))
        {
            OnPointerEnterGoal();
        }
        else
        {
            OnPointerExitGoal();
        }
    }
    #endregion

    public void OnPointerEnterGoal()
    {
        // do stuff if player success
        hint.SetActive(true);
        GlobalVariableManager.solvedPuzzle2 = true;
    }

    public void OnPointerExitGoal()
    {
        pointerSpeed = oriSpeed;
        GlobalVariableManager.chanceToLoseGame += 0.05f;
    }
}
