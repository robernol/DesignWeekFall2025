using System.Collections;
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
    public static bool timerShouldBeActive = false;


    // [Range(0f,1f)] public static float chanceToLoseGame { get; set; } = 0.0f;


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
        if (timeIsDone)
        {
            GameLose();
        }
    }
    #region unse stuff
    //private IEnumerator LoseChanceCouroutine()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(3f);
    //        LoseConsition();
    //    }
    //}

    //private void LoseConsition()
    //{
    //    float escape = Random.Range(0.3f, 1.0f);    
    // //   Debug.Log(escape + " vs " + chanceToLoseGame);

    //    if (escape < chanceToLoseGame)
    //    {
    //        GameLose();
    //    }
    //    else if (timeIsDone)
    //    {
    //        GameLose();
    //    }
    //}
    #endregion

    private void GameLose()
    {
        if (SceneManager.GetActiveScene().name != "Lose") // prevent infinite reloads
        {
            timeIsDone = false;  // Reset before scene load
            SceneManager.LoadScene("Lose");
        }
    }

}
