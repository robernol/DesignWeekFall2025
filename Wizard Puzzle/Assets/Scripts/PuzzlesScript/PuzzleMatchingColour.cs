using TMPro;
using UnityEngine;

public class PuzzleMatchingColour : MonoBehaviour
{

    [Header("Puzzle 2 Text References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI puzzleNum;

    private void Start()
    {
        if (GlobalVariableManager.solvedPuzzle1)
        {
            ShowTranslatedText(puzzleNum, normalFontAsset, puzzleNum.fontSize, 2.ToString());
        }
    }

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }
}
