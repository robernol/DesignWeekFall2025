using UnityEngine;

public class SillyLittleDisappearingGuy : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GetComponent<SpriteRenderer>().enabled)
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().enabled = true;
            }
            
        }
    }
}
