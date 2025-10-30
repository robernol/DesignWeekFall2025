using UnityEngine;
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
        if(Input.GetKey(KeyCode.Space)) isHolding = true;
        else isHolding = false;
    }

    private void ChangeSceneInput()
    {
        if (isHolding)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                LoadPuzzleScene("Scene1");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                LoadPuzzleScene("Scene2");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                LoadPuzzleScene("Scene3");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha4))
            {
                LoadPuzzleScene("Scene4");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha5))
            {
                LoadPuzzleScene("Scene5");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha6))
            {
                LoadPuzzleScene("Scene6");
            }
        }
    }

    public void LoadPuzzleScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
