using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneChangeTesting : MonoBehaviour
{
    private bool isHolding = false;

    private void Update()
    {
        InputPlaceHolder();
        ChangeSceneInput(); 
    }

    private void InputPlaceHolder()
    {
        if (PlayerInput.T2IsHeld) isHolding = true;
        else isHolding = false;
    }

    private void ChangeSceneInput()
    {
        if (isHolding)
        {
            if (PlayerInput.B4IsPressed)
            {
                LoadPuzzleScene("Scene1");
            }
            else if (PlayerInput.B2IsPressed)
            {
                LoadPuzzleScene("Scene2");
            }
            //else if (PlayerInput.B3IsPressed)
            //{
            //    LoadPuzzleScene("Scene3");
            //}
            else if (PlayerInput.B1IsPressed)
            {
                LoadPuzzleScene("Scene4");
            }
            else if (PlayerInput.B5IsPressed)
            {
                LoadPuzzleScene("Scene6");
            }
            else if (GlobalVariableManager.solvedPuzzle4)
            {
                LoadPuzzleScene("Scene5");
            }
        }

        if (GlobalVariableManager.solvedPuzzle5)
        {
            LoadPuzzleScene("Scene5");
        }
    }

    public void LoadPuzzleScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
