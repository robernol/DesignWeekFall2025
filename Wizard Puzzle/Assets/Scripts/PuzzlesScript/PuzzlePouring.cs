using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePouring : MonoBehaviour
{
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
        bottleSlider.value = bottleSlider.minValue;
        targetFill.sprite = whiteFill;   
    }
    private void Update()
    {
        PickFiller();
        PlayerPouringInput();
        Pouring();
    }

    private void PickFiller()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            pickedFill = fillImages[0].sprite;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            pickedFill = fillImages[1].sprite;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            pickedFill = fillImages[2].sprite;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            pickedFill = fillImages[3].sprite;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            pickedFill = fillImages[4].sprite;
        }

        hasPickedFill = true;
    }

    private void Pouring()
    {
        if (isPouring)
        {
            targetFill.sprite = pickedFill;
            bottleSlider.value += pouringSpeed * Time.deltaTime;
        }
    }
    private void PlayerPouringInput()
    {
        // change it to PlayerInput later. 
        if (Input.GetKey(KeyCode.S))
        {
            isPouring = true;
            Debug.Log("Pouring...");
        }
        else
        {
            isPouring = false;
        }
    }

}
