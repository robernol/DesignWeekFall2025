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
    public TextMeshProUGUI titleRune;
    public GameObject hint1;




    private float normalFontSize = 8f;

    private void Start()
    {
      

        if (GlobalVariableManager.solvedPuzzle1)
        {
            // Already solved before
           
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, "Use");
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, "stop");
            ShowTranslatedText(rune4, normalFontAsset, normalFontSize, "stone.");
            ShowTranslatedText(titleRune, normalFontAsset, normalFontSize, "4");


            
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
            string outPutText2 = "stop";
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, outPutText2);
            string outPutText = "4";
             ShowTranslatedText(titleRune, normalFontAsset, 50, outPutText);
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


    private void CheckPuzzle1State()
    {
        if (rune1.font == normalFontAsset && rune2.font == normalFontAsset && rune3.font == normalFontAsset && rune4.font == normalFontAsset)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                // if player pressed the corect rune button shown on the scren --> PlayerInput.cs
                GlobalVariableManager.solvedPuzzle2 = true;
                hint1.SetActive(true);
            }
        }
    }
}
