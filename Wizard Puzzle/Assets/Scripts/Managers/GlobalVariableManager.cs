using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalVariableManager : MonoBehaviour
{
    public static GlobalVariableManager Instance;
 
    public static bool solvedPuzzle1 { get; set; } = false;
    public static bool solvedPuzzle2 { get; set; } = false;
    public static bool solvedPuzzle3 { get; set; } = false;
    public static bool solvedPuzzle4 { get; set; } = false;
    public static bool solvedPuzzle5 { get; set; } = false;
    public static bool solvedPuzzle6 { get; set; } = false;

    public static bool timeIsDone { get; set; } = false;

    public static int playerFalidedTime { get; set; }


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
        LoseConsition();
        Debug.Log(playerFalidedTime);
    }

    private void LoseConsition()
    {
        if (playerFalidedTime > 2)
        {
            SceneManager.LoadScene("Lose");
        }
        else if (timeIsDone)
        {
            SceneManager.LoadScene("Lose");
        }
    }

}
