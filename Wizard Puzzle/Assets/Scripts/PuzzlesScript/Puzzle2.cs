using TMPro;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    [Header("Puzzle 2 Text References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI puzzleNum;
    public GameObject instruction;


    private void Start()
    {
        instruction.SetActive(false);

        if (GlobalVariableManager.solvedPuzzle1)
        {
            ShowTranslatedText(puzzleNum, normalFontAsset, puzzleNum.fontSize, 2.ToString());
            instruction.SetActive(true);
        }
    }

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }
}
