using UnityEngine;
using UnityEngine.UI;

public class PouringMechanic : MonoBehaviour
{
    [Header("Pouring Setting")]
    public Slider pouringFiller;
    public float pouringSpeed = 5f;

    private bool isPouring = false;

    private void Start()
    {
        pouringFiller.value = pouringFiller.minValue;
    }
    private void Update()
    {
        PlayerPouringInput();
        Pouring();
    }

    private void Pouring()
    {
        if (isPouring)
        {
            pouringFiller.value += pouringSpeed * Time.deltaTime;
        }
    }
    private void PlayerPouringInput()
    {
        // change it to PlayerInput later. 
        if (Input.GetKey(KeyCode.P))
        {
            isPouring = true;
            Debug.Log("Pouring...");
        }
        else
        {
            isPouring = false;
        }
    }
}
