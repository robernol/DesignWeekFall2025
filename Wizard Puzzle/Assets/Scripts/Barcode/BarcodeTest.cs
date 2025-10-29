using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class BarcodeTest : MonoBehaviour
{

    #region Resources
    /// <summary>
    /// The barcode scanner looks like a USB keyboard, but grabbing the whole code from Input.inputString
    /// does not get the whole code, it may be split across a few frames. This time is how much time to
    /// wait before assuming we have the whole string now. Long (too many characters) codes may take too long to scan. 
    /// Ideal kind is https://www.labeltac.com/barcode-generator width = 1, height = 150 (more to aim at)
    /// </summary>
    [Tooltip("Time it takes to complete one scan.")]
    public float timeDelay = 0.1f;
    private string currentCode; //current content of the scanned in value
    private string lastCode; //additional copy of the scan so we can trigger a single event on change
    private float lastReceivedInput = 0f; //timestamp for beginning of the scan (trigger pressed)
    
    [Tooltip("Event raised when the barcode has been scanned. Passes the code as a string.")]
    public UnityEvent<string> OnCodeRead;
    #endregion

    [Header("References")]
    public TextMeshProUGUI showingText;


    void Start()
    {
        currentCode = "";
        lastCode = "";
    }

    void Update()
    {
        if (Time.time > lastReceivedInput + timeDelay)
        {
            currentCode = "";
            lastCode = "";
        }
        if (Input.inputString != "")
        {
            currentCode += Input.inputString;
            lastReceivedInput = Time.time;
            
        }
        if (currentCode != lastCode && !string.IsNullOrWhiteSpace(currentCode) && (currentCode[currentCode.Length - 1] == ' ' || currentCode[currentCode.Length - 1] == '\r'))
        {
            lastCode = currentCode;
            OnCodeRead.Invoke(currentCode.Trim());
        }

      //  UpdaetBarcodeOutput();
    }

    public void UpdateText()
    {
            showingText.text = currentCode;
    }

    private void UpdaetBarcodeOutput()
    {
        //This section just checks to see what the output string is. 
        if (currentCode == "Sip")
        {
            Debug.Log("current code is " + currentCode);
        }
        else if (currentCode == "Num")
        {
            Debug.Log("current code is " + currentCode);
        }
        else if (currentCode == "Lob")
        {
            Debug.Log("current code is " + currentCode);
        }
        else if (currentCode == "Grk")
        {
            Debug.Log("current code is " + currentCode);
        }
    }
}
