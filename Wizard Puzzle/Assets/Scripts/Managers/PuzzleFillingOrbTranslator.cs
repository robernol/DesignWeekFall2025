using TMPro;
using UnityEngine;

public class PuzzleFillingOrbTranslator : MonoBehaviour
{
    [Header("osu References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI rune1;
    public TextMeshProUGUI rune2;
    public TextMeshProUGUI rune3;
    public TextMeshProUGUI rune4;
    public TextMeshProUGUI rune5;
    public GameObject controls;
    bool sipScanned = false;
    bool numScanned = false;
    bool lobScanned = false;

    private float normalFontSize = 8f;

    public void UpdateOutputTextWithCondition()
    {
        if (BarcodeTest.currentCode.Trim() == "Sip")
        {
            string outPutText1 = "sealing orb";
            ShowTranslatedText(rune1, normalFontAsset, normalFontSize, outPutText1);
            string outPutText2 = "spirit color";
            ShowTranslatedText(rune3, normalFontAsset, 7, outPutText2);
            sipScanned = true;
        }
        else if (BarcodeTest.currentCode.Trim() == "Num")
        {
            string outPutText1 = "essence";
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, outPutText1);
            string outPutText2 = "weaken";
            ShowTranslatedText(rune4, normalFontAsset, normalFontSize, outPutText2);
            numScanned = true;
        }
        else if (BarcodeTest.currentCode.Trim() == "Lob")
        {
            string outPutText = "break free";
            ShowTranslatedText(rune5, normalFontAsset, normalFontSize, outPutText);
            lobScanned= true;
        }
    }

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }

  
}
