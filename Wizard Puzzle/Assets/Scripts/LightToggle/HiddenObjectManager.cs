using System.Collections.Generic;
using UnityEngine;

public class HiddenObjectManager : MonoBehaviour
{
    [Header("Hidden Object References")]
    public List<GameObject>lightObjects = new List<GameObject>();
    public List<GameObject>darkObjects = new List<GameObject>();

    public static int lightState = 1;

    private void Update()
    {
        UpdateHiddenObjects();  
    }

    private void UpdateHiddenObjects()
    {
        if (lightState == 1)
        {
            foreach (GameObject obj in lightObjects)
            {
                obj.SetActive(true);
            }

            foreach (GameObject obj in darkObjects)
            {
                obj.SetActive(false);
            }
        }
        else if (lightState == 0)
        {
            foreach (GameObject obj in lightObjects)
            {
                obj.SetActive(false);
            }

            foreach (GameObject obj in darkObjects)
            {
                obj.SetActive(true);
            }
        }
    }
}
