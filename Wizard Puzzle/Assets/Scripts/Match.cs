using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Match : MonoBehaviour
{
    public SpriteRenderer st, sb;
    public float timer, displayTime;
    bool isDisplayingSequence;
    KeyCode[] sequence;
    public int inSequence;

    void Start()
    {
        timer = Time.time;
        isDisplayingSequence = false;
        SequenceRandomizer();
        inSequence = 0;
        displayTime = 5;
    }

    void Update()
    {
        if (!isDisplayingSequence)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                st.color = Color.greenYellow;
                sb.color = Color.greenYellow;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.UpArrow);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                st.color = Color.orange;
                sb.color = Color.orange;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.LeftArrow);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                st.color = Color.red;
                sb.color = Color.red;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.DownArrow);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                st.color = Color.yellow;
                sb.color = Color.yellow;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.RightArrow);
            }

            if (Time.time > timer)
            {
                st.color = Color.gray9;
                sb.color = Color.gray9;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                timer = Time.time + displayTime;
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
        if (timer - Time.time > displayTime * (0.95))
        {
            st.color = Color.gray9;
            sb.color = Color.gray9;
        }
        else if (timer - Time.time > displayTime * (0.8))
        {
            DisplayColour(sequence[0]);
        }
        else if (timer - Time.time > displayTime * (0.75))
        {
            st.color = Color.gray7;
            sb.color = Color.gray7;
        }

        else if (timer - Time.time > displayTime * (0.6))
        {
            DisplayColour(sequence[1]);
        }
        else if (timer - Time.time > displayTime * (0.55))
        {
            st.color = Color.gray7;
            sb.color = Color.gray7;
        }

        else if (timer - Time.time > displayTime * (0.4))
        {
            DisplayColour(sequence[2]);
        }
        else if (timer - Time.time > displayTime * (0.35))
        {
            st.color = Color.gray7;
            sb.color = Color.gray7;
        }

        else if (timer - Time.time > displayTime * (0.2))
        {
            DisplayColour(sequence[3]);
        }
        else if (timer - Time.time > displayTime * (0.15))
        {
            st.color = Color.gray7;
            sb.color = Color.gray7;
        }

        else if (timer - Time.time > 0)
        {
            DisplayColour(sequence[4]);
        }
        else
        {
            st.color = Color.white;
            sb.color = Color.white;
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
            st.color = Color.greenYellow;
            sb.color = Color.greenYellow;
        }

        if (k == (KeyCode.LeftArrow))
        {
            st.color = Color.orange;
            sb.color = Color.orange;
        }

        if (k == (KeyCode.DownArrow))
        {
            st.color = Color.red;
            sb.color = Color.red;
        }

        if (k == (KeyCode.RightArrow))
        {
            st.color = Color.yellow;
            sb.color = Color.yellow;
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
                st.color = Color.gray2;
                sb.color = Color.gray2;
                Debug.Log("LOSE!");
                inSequence = 0;
            }
        }
    }
}
