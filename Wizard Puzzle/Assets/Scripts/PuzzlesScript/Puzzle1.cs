using TMPro;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{

    [Header("Puzzle 1 References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI rune1;
    public TextMeshProUGUI rune2;
    public TextMeshProUGUI rune3;
    public GameObject hint1;
    bool sipScanned = false;
    bool numScanned = false;
    bool lobScanned = false;
   // public GameObject hint2;
    //public GameObject hint3;

    private float normalFontSize = 8f;

    private void Start()
    {
        hint1.SetActive(false);

        if (GlobalVariableManager.solvedPuzzle1)
        {
            // Already solved before
            ShowTranslatedText(rune1, normalFontAsset, rune1.fontSize, 1.ToString());
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, "sealing");
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, "button");
            hint1.SetActive(true);
            //hint2.SetActive(true);
          //  hint3.SetActive(true);
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
            sipScanned = true;


        } else if (BarcodeTest.currentCode.Trim() == "Num")
        {
            string outPutText = "sealing";
            ShowTranslatedText(rune2, normalFontAsset, normalFontSize, outPutText);
            numScanned = true;


        } else if (BarcodeTest.currentCode.Trim() == "Lob")
        {
            string outPutText = "button";
            ShowTranslatedText(rune3, normalFontAsset, normalFontSize, outPutText);
            lobScanned = true;


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
        if (sipScanned && numScanned && lobScanned)
        {
            GlobalVariableManager.solvedPuzzle1 = true;
            Debug.Log("finished");
            hint1.SetActive(true);
            
        }
    }
}
