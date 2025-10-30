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

    private int normalFontSize = 8;

    private void Start()
    {
        Next.SetActive(false);
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
            rune1.font = normalFontAsset;
            rune1.text = outPutText;
        } else if (BarcodeTest.currentCode.Trim() == "Num")
        {
            string outPutText = "sealing";
            rune2.font = normalFontAsset;
            rune2.fontSize = normalFontSize;
            rune2.text = outPutText;
        } else if (BarcodeTest.currentCode.Trim() == "Lob")
        {
            string outPutText = "button";
            rune3.font = normalFontAsset;
            rune3.fontSize = normalFontSize;
            rune3.text = outPutText;
        }
    }

    // im just gonna do a quick puzzle 1 state check here, might move it somewhere else later
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
