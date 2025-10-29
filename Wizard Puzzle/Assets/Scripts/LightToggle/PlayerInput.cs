using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static bool leftIsPressed { get; private set; }
    public static bool upIsPressed { get; private set; }
    public static bool rightIsPressed { get; private set; }
    public static bool downIsPressed { get; private set; }
    public static bool firIsPressed { get; private set; }
    public static bool secIsPressed { get; private set; }

    private void Update()
    {
        UpdateInput();   
    }

    private void UpdateInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftIsPressed = true;
            Debug.Log("left");  
        }
        else leftIsPressed = false;

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            upIsPressed = true;
            Debug.Log("up")
;        }
        else upIsPressed = false;
        
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightIsPressed = true;
            Debug.Log("Right");
        }
        else rightIsPressed = false;
        
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            downIsPressed = true;
            Debug.Log("down");
        }
        else downIsPressed = false;
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            firIsPressed = true;
            Debug.Log("first");
        }
        else firIsPressed = false;

        if(Input.GetMouseButtonDown(1))
        {
            secIsPressed = true;
            Debug.Log("second");
        }
        else secIsPressed = false;
    }
}
