using TMPro;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{

    [Header("Puzzle 1 References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI rune1;
    public TextMeshProUGUI rune2;
    public TextMeshProUGUI rune3;
    public GameObject Next;

    private float normalFontSize = 8f;

    private void Start()
    {
        Next.SetActive(false);

        if (GlobalVariableManager.solvedPuzzle1)
        {
            // Already solved before
            ShowTranslatedText(rune1, normalFontAsset, rune1.fontSize, 1.ToString());
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, "sealing");
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, "button");
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
            string outPutText = 1.ToString();
            ShowTranslatedText(rune1, normalFontAsset, rune1.fontSize, outPutText);
        } else if (BarcodeTest.currentCode.Trim() == "Num")
        {
            string outPutText = "sealing";
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, outPutText);
        } else if (BarcodeTest.currentCode.Trim() == "Lob")
        {
            string outPutText = "button";
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, outPutText);
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
        if (rune1.font == normalFontAsset && rune2.font == normalFontAsset && rune3.font == normalFontAsset)
        {
            // tommorow add another if(if player pressed the correct button on the thing
            GlobalVariableManager.solvedPuzzle1 = true;
            Next.SetActive(true);
            Debug.Log("unlock puzzle 2");
        }
    }
}
