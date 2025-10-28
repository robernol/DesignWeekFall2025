using UnityEngine;

public class Match : MonoBehaviour
{
    SpriteRenderer sr;
    float timer;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        timer = Time.time;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            sr.color = Color.greenYellow;
            timer = Time.time + 0.5f;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sr.color = Color.orange;
            timer = Time.time + 0.5f;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            sr.color = Color.red;
            timer = Time.time + 0.5f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sr.color = Color.yellow;
            timer = Time.time + 0.5f;
        }

        if (Time.time > timer)
        {
            sr.color = Color.white;
        }
    }
}
