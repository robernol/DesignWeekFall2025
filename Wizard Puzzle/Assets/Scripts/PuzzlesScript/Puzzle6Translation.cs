using TMPro;
using UnityEngine;

public class Puzzle6Translation : MonoBehaviour
{
    [Header("Puzzle 1 References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI rune1;
    public TextMeshProUGUI rune2;
    public TextMeshProUGUI rune3;
    public TextMeshProUGUI rune4;
    public TextMeshProUGUI rune5;
    public TextMeshProUGUI rune6;
    


    private float normalFontSize = 8f;

    private void Start()
    {


        if (GlobalVariableManager.solvedPuzzle1)
        {
            // Already solved before
            ShowTranslatedText(rune1, normalFontAsset, rune1.fontSize, "Seal");
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, "demon");
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, "away");
            ShowTranslatedText(rune4, normalFontAsset, normalFontSize, "Insert");
            ShowTranslatedText(rune5, normalFontAsset, normalFontSize, "key");
            ShowTranslatedText(rune6, normalFontAsset, normalFontSize, "slot with");



        }
    }
   
    public void UpdateOutputTextWithCondition()
    {
        // Change these later cuz now we only have the placeholder barcode to workwith

        if (BarcodeTest.currentCode.Trim() == "Sip")
        {
            string outPutText2 = "away";
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, outPutText2);
            string outPutText ="Seal";
            ShowTranslatedText(rune1, normalFontAsset, rune1.fontSize, outPutText);
        }
        else if (BarcodeTest.currentCode.Trim() == "Num")
        {
            string outPutText2 = "key";
            ShowTranslatedText(rune5, normalFontAsset, normalFontSize, outPutText2);
            string outPutText = "demon";
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, outPutText);

        }
        else if (BarcodeTest.currentCode.Trim() == "Lob")
        {
            string outPutText2 = "slot with";
            ShowTranslatedText(rune6, normalFontAsset, normalFontSize, outPutText2);
            string outPutText = "Insert";
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
