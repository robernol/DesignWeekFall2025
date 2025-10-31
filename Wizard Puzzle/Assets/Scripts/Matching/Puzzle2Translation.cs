using TMPro;
using UnityEngine;

public class Puzzle2Translation : MonoBehaviour
{
    [Header("Puzzle 1 References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI rune1, rune2, rune3, rune4, rune5, text2, text3, text4, text5;

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }

    public void UpdateOutputTextWithCondition()
    {
        // Change these later cuz now we only have the placeholder barcode to workwith

        if (BarcodeTest.currentCode.Trim() == "Sip")
        {
            rune3.gameObject.SetActive(true);
            text3.gameObject.SetActive(false);
            rune5.gameObject.SetActive(true);
            text5.gameObject.SetActive(false);
            rune2.gameObject.SetActive(true);
            text2.gameObject.SetActive(false);

            string outPutText = 2.ToString();
            ShowTranslatedText(rune1, normalFontAsset, rune1.fontSize, outPutText);
            rune4.gameObject.SetActive(false);
            text4.gameObject.SetActive(true);
        }
        else if (BarcodeTest.currentCode.Trim() == "Num")
        {
            rune5.gameObject.SetActive(true);
            text5.gameObject.SetActive(false);
            rune2.gameObject.SetActive(true);
            text2.gameObject.SetActive(false);
            rune4.gameObject.SetActive(true);
            text4.gameObject.SetActive(false);

            rune3.gameObject.SetActive(false);
            text3.gameObject.SetActive(true);
        }
        else if (BarcodeTest.currentCode.Trim() == "Lob")
        {
            rune3.gameObject.SetActive(true);
            text3.gameObject.SetActive(false);
            rune4.gameObject.SetActive(true);
            text4.gameObject.SetActive(false);


            rune5.gameObject.SetActive(false);
            text5.gameObject.SetActive(true);
            rune2.gameObject.SetActive(false);
            text2.gameObject.SetActive(true);
        }
    }


}
