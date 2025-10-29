using UnityEngine;

public class GlobalVariableManager : MonoBehaviour
{
    public static GlobalVariableManager Instance;

    [Header("Global Variables")]   
    public static bool solvedPuzzle1 { get; set; } = false;

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

}
