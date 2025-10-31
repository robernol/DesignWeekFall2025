using TMPro;
using UnityEngine;

public class PuzzleMatchingColour : MonoBehaviour
{

    [Header("Puzzle 2 Text References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI puzzleNum;

    public GameObject Instruction1;
    public GameObject Instruction2;

    public GameObject solvedPuzzle;
    public GameObject nextHint;

    public SpriteRenderer borderTop;
    public SpriteRenderer borderBottom;
    private Color newTopColor = new Color(229f/255f, 187f/255f, 253f/255f);
    private Color newBottomColor = new Color(230f/255f, 186/255f, 255f/255f);


    private void Start()
    {
        Instruction1.SetActive(false); Instruction2.SetActive(false);
        solvedPuzzle.SetActive(false);
        nextHint.SetActive(false);

        if (GlobalVariableManager.solvedPuzzle1)
        {
            ShowTranslatedText(puzzleNum, normalFontAsset, puzzleNum.fontSize, 2.ToString());
            Instruction1.SetActive(true); Instruction2.SetActive(true);
        }

        if (GlobalVariableManager.solvedPuzzle2)
        {
            solvedPuzzle.SetActive(true);
            borderTop.color = newTopColor;
            borderBottom.color = newBottomColor;
        }
    }

    private void Update()
    {
        ShowSolvedFeedback();
    }

    private void ShowSolvedFeedback()
    {
        if (GlobalVariableManager.solvedPuzzle2)
        {
            borderTop.color = newTopColor;
            borderBottom.color = newBottomColor;
            nextHint.SetActive(true);
        }
    }

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }
}
