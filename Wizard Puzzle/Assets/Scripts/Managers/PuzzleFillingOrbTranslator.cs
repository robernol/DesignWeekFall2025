using TMPro;
using UnityEngine;

public class PuzzleFillingOrbTranslator : MonoBehaviour
{
    [Header("Text References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI rune1;
    public TextMeshProUGUI rune2;
    public TextMeshProUGUI rune3;
    public TextMeshProUGUI rune4;
    public TextMeshProUGUI rune5;

    private float normalFontSize = 8f;

    private void Start()
    {
        if (GlobalVariableManager.solvedPuzzle3)
        {
            #region show all transleated text
            ShowTranslatedText(rune1, normalFontAsset, normalFontSize, "sealing orb");
            ShowTranslatedText(rune3, normalFontAsset, 7, "spirit color");
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, "essence");
            ShowTranslatedText(rune4, normalFontAsset, normalFontSize, "weaken");
            ShowTranslatedText(rune5, normalFontAsset, normalFontSize, "break free");
            #endregion
        }
    }

    #region Text Stuff
    public void UpdateOutputTextWithCondition()
    {
        if (BarcodeTest.currentCode.Trim() == "Sip")
        {
            string outPutText1 = "sealing orb";
            ShowTranslatedText(rune1, normalFontAsset, normalFontSize, outPutText1);
            string outPutText2 = "spirit color";
            ShowTranslatedText(rune3, normalFontAsset, 7, outPutText2);
        }
        else if (BarcodeTest.currentCode.Trim() == "Num")
        {
            string outPutText1 = "essence";
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, outPutText1);
            string outPutText2 = "weaken";
            ShowTranslatedText(rune4, normalFontAsset, normalFontSize, outPutText2);
        }
        else if (BarcodeTest.currentCode.Trim() == "Lob")
        {
            string outPutText = "break free";
            ShowTranslatedText(rune5, normalFontAsset, normalFontSize, outPutText);
        }
    }
    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }
    #endregion

}
