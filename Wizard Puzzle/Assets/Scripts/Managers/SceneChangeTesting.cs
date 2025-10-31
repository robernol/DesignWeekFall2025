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
        //if(PlayerInput.T2IsHeld) isHolding = true;
        //else isHolding = false;
        if (Input.GetKey(KeyCode.Space)) isHolding = true;
        else isHolding = false;
    }

    private void ChangeSceneInput()
    {
        //if (isHolding)
        //{
        //    if(PlayerInput.B4IsPressed)
        //    {
        //        LoadPuzzleScene("Scene1");
        //    }
        //    else if(PlayerInput.B2IsPressed)
        //    {
        //        LoadPuzzleScene("Scene2");
        //    }
        //    else if(PlayerInput.B3IsPressed)
        //    {
        //        LoadPuzzleScene("Scene3");
        //    }
        //    else if(PlayerInput.B1IsPressed)
        //    {
        //        LoadPuzzleScene("Scene4");
        //    }
        //    else if(Input.GetKeyDown(KeyCode.Q))
        //    {
        //        LoadPuzzleScene("Scene6");
        //    }
        //    else if(GlobalVariableManager.solvedPuzzle5)
        //    {
        //        LoadPuzzleScene("Scene5");
        //    }
        //}

        if (isHolding)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                LoadPuzzleScene("Scene1");
            } else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                LoadPuzzleScene("Scene2");
            } else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                LoadPuzzleScene("Scene3");
            } else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                LoadPuzzleScene("Scene4");
            } else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                LoadPuzzleScene("Scene6");
            } else if (GlobalVariableManager.solvedPuzzle5)
            {
                LoadPuzzleScene("Scene5");
            }
        }
    }

    public void LoadPuzzleScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
