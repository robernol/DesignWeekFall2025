using TMPro;
using UnityEngine;

public class Puzzle2Translation : MonoBehaviour
{
    [Header("Puzzle 1 References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI rune1, rune2, rune3, rune4, rune5;
    bool sip, num, lob;
    private float normalFontSize = 8f;

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
        sip = false;
        num = false;
        lob = false;
    }

    public void UpdateOutputTextWithCondition()
    {
        // Change these later cuz now we only have the placeholder barcode to workwith

        if (BarcodeTest.currentCode.Trim() == "Sip")
        {
            sip = true;
            num = false;
            lob = false;

            string outPutText = 2.ToString();
            ShowTranslatedText(rune1, normalFontAsset, rune1.fontSize, outPutText);
            outPutText = "Yellow";
            ShowTranslatedText(rune4, normalFontAsset, normalFontSize, outPutText);
        }
        else if (BarcodeTest.currentCode.Trim() == "Num")
        {
            string outPutText = "Green";
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, outPutText);
        }
        else if (BarcodeTest.currentCode.Trim() == "Lob")
        {
            string outPutText = "Blue";
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, outPutText);
            outPutText = "Red";
            ShowTranslatedText(rune5, normalFontAsset, normalFontSize, outPutText);
        }
    }


}
