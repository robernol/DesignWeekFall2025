using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Match : MonoBehaviour
{
    public SpriteRenderer st, sb;
    public float timer, displayTime, endTime;
    bool isDisplayingSequence, completed;
    KeyCode[] sequence;
    public int inSequence;

    void Start()
    {
        timer = Time.time;
        isDisplayingSequence = false;
        SequenceRandomizer();
        inSequence = 0;
        displayTime = 5;
        completed = false;
    }

    void Update()
    {
        if (!isDisplayingSequence)
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                st.color = Color.greenYellow;
                sb.color = Color.greenYellow;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.H);
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                st.color = Color.orange;
                sb.color = Color.orange;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.J);
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                st.color = Color.softRed;
                sb.color = Color.softRed;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.L);
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                st.color = Color.yellow;
                sb.color = Color.yellow;
                timer = Time.time + 0.5f;
                CheckCorrectInput(KeyCode.K);
            }

            if (Time.time > timer)
            {
                st.color = Color.gray9;
                sb.color = Color.gray9;
                if (completed)
                {
                    st.color = Color.mediumPurple;
                    sb.color = Color.mediumPurple;
                }
            }

            if ((Input.GetKeyDown(KeyCode.Space)) && !completed)
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
            st.color = Color.gray9;
            sb.color = Color.gray9;
        }

        else if (timer - Time.time > displayTime * (0.6))
        {
            DisplayColour(sequence[1]);
        }
        else if (timer - Time.time > displayTime * (0.55))
        {
            st.color = Color.gray9;
            sb.color = Color.gray9;
        }

        else if (timer - Time.time > displayTime * (0.4))
        {
            DisplayColour(sequence[2]);
        }
        else if (timer - Time.time > displayTime * (0.35))
        {
            st.color = Color.gray9;
            sb.color = Color.gray9;
        }

        else if (timer - Time.time > displayTime * (0.2))
        {
            DisplayColour(sequence[3]);
        }
        else if (timer - Time.time > displayTime * (0.15))
        {
            st.color = Color.gray9;
            sb.color = Color.gray9;
        }

        else if (timer - Time.time > 0)
        {
            DisplayColour(sequence[4]);
        }
        else
        {
            st.color = Color.mediumPurple;
            sb.color = Color.mediumPurple;
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
                sequence[i] = KeyCode.H;
            }
            else if (r <= 1.99f)
            {
                sequence[i] = KeyCode.J;
            }
            else if (r <= 2.99f)
            {
                sequence[i] = KeyCode.L;
            }
            else
            {
                sequence[i] = KeyCode.K;
            }
        }
    }

    void DisplayColour(KeyCode k)
    {
        if (k == (KeyCode.H))
        {
            st.color = Color.deepSkyBlue;
            sb.color = Color.cornflowerBlue;
        }

        if (k == (KeyCode.J))
        {
            st.color = Color.springGreen;
            sb.color = Color.mediumSeaGreen;
        }

        if (k == (KeyCode.L))
        {
            st.color = Color.softRed;
            sb.color = Color.softRed;
        }

        if (k == (KeyCode.K))
        {
            st.color = Color.yellow;
            sb.color = Color.goldenRod;
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
                    completed = true;
                    Debug.Log("WIN!" + completed);
                    st.color = Color.mediumPurple;
                    sb.color = Color.mediumPurple;
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
