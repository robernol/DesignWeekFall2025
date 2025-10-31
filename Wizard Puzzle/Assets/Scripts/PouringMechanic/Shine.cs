using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Shine : MonoBehaviour
{
    private Image image;

    public float fadeDuration = 1.5f;
    public float minAlpha = 0.3f;
    public float maxAlpha = 1f;

    private bool isShining = false;


    private void Start()
    {
        image = GetComponent<Image>();
        StartCoroutine(ShineLoop());
    }

    IEnumerator ShineLoop()
    {
        isShining = true;

        // Loop forever
        while (isShining)
        {
            // Fade in
            yield return StartCoroutine(FadeAlpha(maxAlpha));
            // Fade out
            yield return StartCoroutine(FadeAlpha(minAlpha));
        }
    }

    IEnumerator FadeAlpha(float targetAlpha)
    {
        float elapsed = 0f;
        float startAlpha = GetCurrentAlpha();

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            float newAlpha = Mathf.Lerp(startAlpha, targetAlpha, elapsed / fadeDuration);
            SetAlpha(newAlpha);
            yield return null;
        }

        SetAlpha(targetAlpha);
    }

    float GetCurrentAlpha()
    {   
            return image.color.a;
    }

    void SetAlpha(float alpha)
    {
            Color c = image.color;
            c.a = alpha;
            image.color = c;
    }
}

