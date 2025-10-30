using UnityEngine;

public class GlobalVariableManager : MonoBehaviour
{
    public static GlobalVariableManager Instance;
 
    public static bool solvedPuzzle1 { get; set; } = false;
    public static bool solvedPuzzle2 { get; set; } = false;
    public static bool solvedPuzzle3 { get; set; } = false;
    public static bool solvedPuzzle4 { get; set; } = false;
    public static bool solvedPuzzle5 { get; set; } = false;
    public static bool solvedPuzzle6 { get; set; } = false;

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
