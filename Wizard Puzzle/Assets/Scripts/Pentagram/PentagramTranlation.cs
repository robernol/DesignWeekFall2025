using TMPro;
using UnityEngine;

public class PentagramTranlation : MonoBehaviour
{
    [Header("Puzzle 1 References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI rune2, rune3;
    private float normalFontSize = 8f;

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }

    public void UpdateOutputTextWithCondition()
    {
        if (BarcodeTest.currentCode.Trim() == "Num")
        {
            string outPutText = "unholy";
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, outPutText);
        }
        else if (BarcodeTest.currentCode.Trim() == "Lob")
        {
            string outPutText = "equal.";
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, outPutText);
        }
    }


}
