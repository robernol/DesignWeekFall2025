using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static bool firButtonIsPressed { get; private set; }
    public static bool secButtonIsPressed { get; private set; }
    public static bool thirdButtonIsPressed { get; private set; }
    public static bool fourButtonIsPressed { get; private set; }
    public static bool fithButtonIsPressed { get; private set; }
    public static bool sixButtonIsPressed { get; private set; }

    private void Update()
    {
        UpdateInput();   
    }

    private void UpdateInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            firButtonIsPressed = true;
        }
        else firButtonIsPressed = false;

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            secButtonIsPressed = true;
        }
        else secButtonIsPressed = false;
        
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            thirdButtonIsPressed = true;
        }
        else thirdButtonIsPressed = false;
        
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            fourButtonIsPressed = true;
        }
        else fourButtonIsPressed = false;
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            fithButtonIsPressed = true;
        }
        else fithButtonIsPressed = false;

        if(Input.GetMouseButtonDown(1))
        {
            sixButtonIsPressed = true;
        }
        else sixButtonIsPressed = false;


    }
}
