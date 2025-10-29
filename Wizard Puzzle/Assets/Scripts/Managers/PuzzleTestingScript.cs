using TMPro;
using UnityEngine;

public class PuzzleTestingScript : MonoBehaviour
{
    public TextMeshProUGUI puzzle1StateText;

    private void Update()
    {
        if(GlobalVariableManager.solvedPuzzle1)
        {
            puzzle1StateText.text = "Puzzle 1 Solved!";
        }
        else
        {
            puzzle1StateText.text = "Puzzle 1 Not Solved";
        }
    }

    public void Puzzle1State()
    {
        // player did something and solved puzzle 1
        GlobalVariableManager.solvedPuzzle1 = true;
    }


}
