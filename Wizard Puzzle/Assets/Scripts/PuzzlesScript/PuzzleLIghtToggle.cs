using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuzzleLIghtToggle : MonoBehaviour
{
    [Header("Puzzle 3 Text References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI puzzleNum;
    //public GameObject hint;

    [Header("Light References")]
    public GameObject lightOffOverlay;

    private bool lightOn = true;

    [Header("Hidden Object References")]
    public List<GameObject> lightObjects = new List<GameObject>();
    public List<GameObject> darkObjects = new List<GameObject>();

    public static int lightState = 1;

    private void Start()
    {
        if(GlobalVariableManager.solvedPuzzle4)
        {
            ShowTranslatedText(puzzleNum, normalFontAsset, puzzleNum.fontSize, 5.ToString());
        }
    }

    private void Update()
    {
        SwitchLight();
        ToggleLight();
        UpdateHiddenObjects();
    }

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }

    #region Light Toggle Logic
    private void ToggleLight()
    {
        if (lightOn)
        {
            lightOffOverlay.SetActive(false);
            lightState = 1;
        }
        else if (!lightOn)
        {
            lightOffOverlay.SetActive(true);
            lightState = 0;
        }
    }

    private void SwitchLight()
    {
        // change this into PlayerInput.cs later
        if (Input.GetKeyDown(KeyCode.W))
        {
            //Playeinput.B5
            lightOn = !lightOn;
        }
    }
    #endregion

    #region Hidden Object Logic
    private void UpdateHiddenObjects()
    {
        if (lightState == 1)
        {
            foreach (GameObject obj in lightObjects)
            {
                obj.SetActive(true);
            }

            foreach (GameObject obj in darkObjects)
            {
                obj.SetActive(false);
            }
        }
        else if (lightState == 0)
        {
            foreach (GameObject obj in lightObjects)
            {
                obj.SetActive(false);
            }

            foreach (GameObject obj in darkObjects)
            {
                obj.SetActive(true);
            }
        }
    }
    #endregion
}
