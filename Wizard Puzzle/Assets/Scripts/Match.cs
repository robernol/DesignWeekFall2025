using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Match : MonoBehaviour
{
    SpriteRenderer sr;
    public float timer;
    bool isDisplayingSequence;
    KeyCode[] sequence;
    public int inSequence;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        timer = Time.time;
        isDisplayingSequence = false;
        SequenceRandomizer();
        inSequence = 0;
    }

    void Update()
    {
        if (!isDisplayingSequence)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                sr.color = Color.greenYellow;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.UpArrow);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                sr.color = Color.orange;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.LeftArrow);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                sr.color = Color.red;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.DownArrow);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                sr.color = Color.yellow;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.RightArrow);
            }

            if (Time.time > timer)
            {
                sr.color = Color.white;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                timer = Time.time + 4.5f;
                SequenceRandomizer();
                isDisplayingSequence = true;
                inSequence = 0;
            }
        }
        else
        {
            DisplaySequence();
        }
        
    }
    void DisplaySequence()
    {
        if (timer - Time.time > 4.5)
        {
        }

        else if (timer-Time.time > 4)
        {
            DisplayColour(sequence[0]);
        }
        else if (timer - Time.time > 3.5)
        {
            sr.color = Color.white;
        }

        else if (timer - Time.time > 3)
        {
            DisplayColour(sequence[1]);
        }
        else if (timer - Time.time > 2.5)
        {
            sr.color = Color.white;
        }

        else if (timer - Time.time > 2)
        {
            DisplayColour(sequence[2]);
        }
        else if (timer - Time.time > 1.5)
        {
            sr.color = Color.white;
        }

        else if (timer - Time.time > 1)
        {
            DisplayColour(sequence[3]);
        }
        else if (timer - Time.time > 0.5)
        {
            sr.color = Color.white;
        }

        else if (timer - Time.time > 0)
        {
            DisplayColour(sequence[4]);
        }
        else
        {
            sr.color = Color.white;
            isDisplayingSequence = false;
        }
    }

    void SequenceRandomizer()
    {
        sequence = new KeyCode[5];
        for (int i = 0; i < sequence.Length; i++)
        {
            float r = UnityEngine.Random.Range(0.0f, 4.0f);
            if (r <= 0.99f)
            {
                sequence[i] = KeyCode.UpArrow;
            }
            else if (r <= 1.99f)
            {
                sequence[i] = KeyCode.LeftArrow;
            }
            else if (r <= 2.99f)
            {
                sequence[i] = KeyCode.DownArrow;
            }
            else
            {
                sequence[i] = KeyCode.RightArrow;
            }
        }
    }

    void DisplayColour(KeyCode k)
    {
        if (k == (KeyCode.UpArrow))
        {
            sr.color = Color.greenYellow;
        }

        if (k == (KeyCode.LeftArrow))
        {
            sr.color = Color.orange;
        }

        if (k == (KeyCode.DownArrow))
        {
            sr.color = Color.red;
        }

        if (k == (KeyCode.RightArrow))
        {
            sr.color = Color.yellow;
        }
    }

    void CheckCorrectInput (KeyCode k)
    {
        if (inSequence < 5)
        {
            if (k == sequence[inSequence])
            {
                inSequence++;
                if (inSequence > 4)
                {
                    Debug.Log("WIN!");
                }
            }
            else
            {
                sr.color = Color.black;
                Debug.Log("LOSE!");
                inSequence = 6;
            }
        }
    }
}
