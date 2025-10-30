    using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static PlayerInput Instance;

    public static bool leftIsPressed { get; private set; }
    public static bool upIsPressed { get; private set; }
    public static bool rightIsPressed { get; private set; }
    public static bool downIsPressed { get; private set; }
    public static bool firIsPressed { get; private set; }
    public static bool secIsPressed { get; private set; }

    public static bool leftIsHeld { get; private set; }
    public static bool upIsHeld { get; private set; }
    public static bool rightIsHeld { get; private set; }
    public static bool downIsHeld { get; private set; }
    public static bool firIsHeld { get; private set; }
    public static bool secIsHeld { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        UpdateInput();   
    }

    private void UpdateInput()
    {
        #region For presseing input
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
        #endregion

        #region For holding input
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftIsHeld = true;
            Debug.Log("left");
        }
        else leftIsHeld = false;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            upIsHeld = true;
            Debug.Log("up")
;
        }
        else upIsHeld = false;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightIsHeld = true;
            Debug.Log("Right");
        }
        else rightIsHeld = false;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            downIsHeld = true;
            Debug.Log("down");
        }
        else downIsHeld = false;

        if (Input.GetKey(KeyCode.Space))
        {
            firIsHeld = true;
            Debug.Log("first");
        }
        else firIsHeld = false;

        if (Input.GetMouseButton(1))
        {
            secIsHeld = true;
            Debug.Log("second");
        }
        else secIsHeld = false;
        #endregion
    }
}
