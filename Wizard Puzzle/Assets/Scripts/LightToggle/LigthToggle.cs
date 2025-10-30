using UnityEngine;

public class LigthToggle : MonoBehaviour
{
    [Header("Light References")]
    public GameObject lightOnOverlay;
    public GameObject lightOffOverlay;

    private bool lightOn = true;  


    private void Update()
    {
        SwitchLight();
        ToggleLight();
    }

    private void ToggleLight()
    {
        if (lightOn)
        {  
            lightOnOverlay.SetActive(true);
            lightOffOverlay.SetActive(false);
            HiddenObjectManager.lightState = 1;
        }
        else if(!lightOn)
        {
            lightOnOverlay.SetActive(false);
            lightOffOverlay.SetActive(true);
            HiddenObjectManager.lightState = 0;
        }
    }

    private void SwitchLight()
    {
        // change this into PlayerInput.fithButtonIsPressed if using the PlayerInput script
        //if (PlayerInput.leftIsPressed)
        //{
        //    lightOn = !lightOn;        
        //}
    }
}
