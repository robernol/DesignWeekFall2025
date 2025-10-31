using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalPuzzleScript : MonoBehaviour
{
    public TMP_FontAsset normalFontAsset;
    public TextMeshProUGUI puzzleNum;

    private void Start()
    {
        if (GlobalVariableManager.solvedPuzzle5)
        {
            ShowTranslatedText(puzzleNum, normalFontAsset, puzzleNum.fontSize, 6.ToString());
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(6);
            Debug.Log("key down");
        }
    }
    private void ShowTranslatedText(TextMeshProUGUI targetText, TMP_FontAsset targetFont, float targetFontSize, string theOutputText)
    {
        targetText.font = targetFont;
        targetText.fontSize = targetFontSize;
        targetText.text = theOutputText;
    }

}
