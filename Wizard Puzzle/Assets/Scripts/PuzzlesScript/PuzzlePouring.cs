using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePouring : MonoBehaviour
{
    [Header("Puzzle 3 Text References")]
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI puzzleNum;
    public GameObject instruction1;
    public GameObject instruction2;
    public GameObject nextHint;

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
    public GameObject shine; // this is to show that the puzzle is complete. sprite is also called shine. 

    private void Start()
    {
        shine.SetActive(false);
        instruction1.SetActive(false);
        instruction2.SetActive(false);
        nextHint.SetActive(false);

        bottleSlider.value = bottleSlider.minValue;

        if (GlobalVariableManager.solvedPuzzle2)
        {
            ShowTranslatedText(puzzleNum, normalFontAsset, puzzleNum.fontSize, 3.ToString());
            instruction1.SetActive(true);
            instruction2.SetActive(true);
        }

        if(GlobalVariableManager.solvedPuzzle3)
        {
            targetFill.sprite = fillImages[3].sprite;
            bottleSlider.value += bottleSlider.maxValue;
            shine.SetActive(true);
        }
        
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
            if (PlayerInput.B4IsPressed)
            {
                // PlayerInput.B4
                pickedFill = fillImages[0].sprite;
                hasPickedFill = true;
            }
            else if (PlayerInput.B1IsPressed)
            {
                // PlayerInput.B1
                pickedFill = fillImages[1].sprite;
                hasPickedFill = true;
            }
            else if (PlayerInput.B2IsPressed)
            {
                // PlayerInput.B2
                pickedFill = fillImages[2].sprite;
                hasPickedFill = true;
            }
            else if (PlayerInput.B3IsPressed)
            {
                // PlayerInput.B3
                pickedFill = fillImages[3].sprite;
                hasPickedFill = true;
            }
            else if (PlayerInput.B5IsPressed)
            {
                // PlayerInput.B5
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
        if (Input.GetKey(KeyCode.Space))
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
            GlobalVariableManager.solvedPuzzle3 = true;
            shine.SetActive(true);
            nextHint.SetActive(true);
        }   
        else if(targetFill.sprite != fillImages[3].sprite && bottleSlider.value >= bottleSlider.maxValue)
        {
            bottleSlider.value = bottleSlider.minValue;
            targetFill.sprite = whiteFill;
            hasPickedFill = false;
           // GlobalVariableManager.chanceToLoseGame += 0.05f;
        }
    }

    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }

}
