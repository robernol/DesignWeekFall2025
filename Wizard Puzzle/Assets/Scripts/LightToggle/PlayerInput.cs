    using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static PlayerInput Instance;

    public static bool B1IsPressed { get; private set; }
    public static bool B2IsPressed { get; private set; }
    public static bool B3IsPressed { get; private set; }
    public static bool B4IsPressed { get; private set; }
    public static bool B5IsPressed { get;  set; }

    public static bool T1IsHeld { get; private set; }
    public static bool T2IsHeld { get; private set; }

    public static bool W2IsInserted { get; private set; }

    // debounce the w key
    private float debounceTime = 0.2f;  // 200 ms debounce delay
    private float lastWPressTime = -1f;




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
        if (Input.GetKeyDown(KeyCode.H))
        {
            B1IsPressed = true;
            Debug.Log("h");  
        }
        else B1IsPressed = false;

        if(Input.GetKeyDown(KeyCode.J))
        {
            B2IsPressed = true;
            Debug.Log("j")
;        }
        else B2IsPressed = false;
        
        if(Input.GetKeyDown(KeyCode.L))
        {
            B3IsPressed = true;
            Debug.Log("l");
        }
        else B3IsPressed = false;
        
        if(Input.GetKeyDown(KeyCode.K) )
        {
            B4IsPressed = true;
            Debug.Log("k");
        }
        else B4IsPressed = false;

        if (Input.GetKeyDown(KeyCode.W) && Time.time - lastWPressTime > debounceTime)
        {
            B5IsPressed = true;
            Debug.Log("w");
            lastWPressTime = Time.time;

            //if (B5IsPressed && lastWPressTime + debounceTime >= Time.time) ;

        }
        else B5IsPressed = false;
        #endregion

            #region For holding input
        if (Input.GetMouseButton(1))
        {
            T1IsHeld = true;
            Debug.Log("click");
        }
        else T1IsHeld = false;

        if (Input.GetKey(KeyCode.Space))
        {
            T2IsHeld = true;
            Debug.Log("space");
        }
        else T2IsHeld = false;
        #endregion

        #region For Wire
        if (Input.GetKeyDown(KeyCode.A))
        {
            W2IsInserted = true;
            Debug.Log("a");
        }
        else
        {
            W2IsInserted = false;
        }
        #endregion
    }
}
