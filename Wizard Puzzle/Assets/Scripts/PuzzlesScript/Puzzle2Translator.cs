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
      

        if (GlobalVariableManager.solvedPuzzle1)
        {
            // Already solved before
            ShowTranslatedText(rune1, normalFontAsset, rune1.fontSize, 2.ToString());
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, "Use");
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, "stop");
            ShowTranslatedText(rune4, normalFontAsset, normalFontSize, "stone.");


            
        }
    }
    private void Update()
    {
        CheckPuzzle1State();
    }
    public void UpdateOutputTextWithCondition()
    {
        // Change these later cuz now we only have the placeholder barcode to workwith

        if (BarcodeTest.currentCode.Trim() == "Sip")
        {
            string outPutText =2.ToString();
            ShowTranslatedText(rune1, normalFontAsset, rune1.fontSize, outPutText);
        }
        else if (BarcodeTest.currentCode.Trim() == "Num")
        {
            string outPutText = "Use";
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, outPutText);
            string outPutText2 = "stop";
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, outPutText2);
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


    private void CheckPuzzle1State()
    {
        if (rune1.font == normalFontAsset && rune2.font == normalFontAsset && rune3.font == normalFontAsset && rune4.font == normalFontAsset)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                // if player pressed the corect rune button shown on the scren --> PlayerInput.cs
                GlobalVariableManager.solvedPuzzle2 = true;
                
            }
        }
    }
}
