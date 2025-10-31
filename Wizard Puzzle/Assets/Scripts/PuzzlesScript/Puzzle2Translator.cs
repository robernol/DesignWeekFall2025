using TMPro;
using UnityEngine;

public class Puzzle2Translator : MonoBehaviour
{
    [Header("Puzzle 1 References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI rune1;
    public TextMeshProUGUI rune2;
    public TextMeshProUGUI rune3;
    public TextMeshProUGUI rune4;

    private float normalFontSize = 8f;

    private void Start()
    {
        if (GlobalVariableManager.solvedPuzzle4)
        {
            // Already solved before
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, "Use");
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, "stop");
            ShowTranslatedText(rune4, normalFontAsset, normalFontSize, "stone.");
        }
    }

    public void UpdateOutputTextWithCondition()
    {
        if (BarcodeTest.currentCode.Trim() == "Sip")
        {
            string outPutText2 = "stop";
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, outPutText2);
        }
        else if (BarcodeTest.currentCode.Trim() == "Num")
        {
            string outPutText = "Use";
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, outPutText);

        }
        else if (BarcodeTest.currentCode.Trim() == "Lob")
        {
            string outPutText = "stone.";
            ShowTranslatedText(rune4, normalFontAsset, normalFontSize, outPutText);
        }
    }

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }
}
