using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePouring : MonoBehaviour
{
    [Header("Puzzle 3 Text References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI puzzleNum;

    [Header("Pouring Setting")]
    public Slider bottleSlider;
    public Image targetFill;
    public float pouringSpeed = 5f;

    private bool isPouring = false;
    private Sprite pickedFill;
    private bool hasPickedFill = false;

    [Header("Puzzle Setting")]
    public List<Image> fillImages = new List<Image>();
    public Sprite whiteFill;

    private void Start()
    {
        if (GlobalVariableManager.solvedPuzzle2)
        {
            ShowTranslatedText(puzzleNum, normalFontAsset, puzzleNum.fontSize, 3.ToString());
        }

        bottleSlider.value = bottleSlider.minValue;
    }
    private void Update()
    {
        PickFiller();
        PlayerPouringInput();
        Pouring();

        PouringPuzzle();
    }

    #region Filler logic
    private void PickFiller()
    {
        if (!hasPickedFill)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                pickedFill = fillImages[0].sprite;
                hasPickedFill = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                pickedFill = fillImages[1].sprite;
                hasPickedFill = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                pickedFill = fillImages[2].sprite;
                hasPickedFill = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                pickedFill = fillImages[3].sprite;
                hasPickedFill = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                pickedFill = fillImages[4].sprite;
                hasPickedFill = true;
            }
        }
    }

    private void Pouring()
    {
        if (isPouring)
        {
            if (hasPickedFill)
            {
                targetFill.sprite = pickedFill;
                bottleSlider.value += pouringSpeed * Time.deltaTime;
            }
        }
      
    }
    private void PlayerPouringInput()
    {
        // change it to PlayerInput later. 
        if (Input.GetKey(KeyCode.S))
        {
            isPouring = true;
        }
        else
        {
            isPouring = false;
        }
    }
    #endregion

    private void PouringPuzzle()
    {
        if(targetFill.sprite == fillImages[3].sprite && bottleSlider.value >= bottleSlider.maxValue)
        {
            // Puzzle Solved
            Debug.Log("Puzzle Solved!");
            GlobalVariableManager.solvedPuzzle3 = true;
        }
        else if(targetFill.sprite != fillImages[3].sprite && bottleSlider.value >= bottleSlider.maxValue)
        {
            bottleSlider.value = bottleSlider.minValue;
            targetFill.sprite = whiteFill;
            hasPickedFill = false;
            GlobalVariableManager.chanceToLoseGame += 0.05f;
        }
    }

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }

}
