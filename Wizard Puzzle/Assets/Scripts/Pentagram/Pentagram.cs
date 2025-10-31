using System.ComponentModel;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pentagram : MonoBehaviour
{
    GameObject[] lineDrawer;
    public GameObject p1, p2, p3, p4, p5, lineDraw, baphomet;
    GameObject lastSelected;
    Vector3[] start, end;
    public int lines;
    bool l1, l2, l3, l4, l5, completed;
    void Start()
    {
        start = new Vector3[5];
        end = new Vector3[5];
        lines = 0;
        lineDrawer = new GameObject[5];
        lastSelected = null;
        l1 = false;
        l2 = false;
        l3 = false;
        l4 = false;
        l5 = false;
        completed = false;
        if (GlobalVariableManager.solvedPuzzle4 == true)
        {
            completed = true;
        }
    }

    void Update()
    {   if (!completed && GlobalVariableManager.solvedPuzzle4)
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                if (lastSelected == null)
                {
                    lastSelected = p1;
                }
                else if (lastSelected == p1)
                {
                    lastSelected = null;
                }
                else
                {
                    lineDrawer[lines] = Instantiate(lineDraw, this.transform);

                    start[lines] = lastSelected.transform.position;
                    end[lines] = p1.transform.position;
                    lastSelected = null;
                    lines++;
                }
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                if (lastSelected == null)
                {
                    lastSelected = p2;
                }
                else if (lastSelected == p2)
                {
                    lastSelected = null;
                }
                else
                {
                    lineDrawer[lines] = Instantiate(lineDraw, this.transform);

                    start[lines] = lastSelected.transform.position;
                    end[lines] = p2.transform.position;
                    lastSelected = null;
                    lines++;
                }
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                if (lastSelected == null)
                {
                    lastSelected = p3;
                }
                else if (lastSelected == p3)
                {
                    lastSelected = null;
                }
                else
                {
                    lineDrawer[lines] = Instantiate(lineDraw, this.transform);

                    start[lines] = lastSelected.transform.position;
                    end[lines] = p3.transform.position;
                    lastSelected = null;
                    lines++;
                }
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                if (lastSelected == null)
                {
                    lastSelected = p4;
                }
                else if (lastSelected == p4)
                {
                    lastSelected = null;
                }
                else
                {
                    lineDrawer[lines] = Instantiate(lineDraw, this.transform);

                    start[lines] = lastSelected.transform.position;
                    end[lines] = p4.transform.position;
                    lastSelected = null;
                    lines++;
                }
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                if (lastSelected == null)
                {
                    lastSelected = p5;
                }
                else if (lastSelected == p5)
                {
                    lastSelected = null;
                }
                else
                {
                    lineDrawer[lines] = Instantiate(lineDraw, this.transform);

                    start[lines] = lastSelected.transform.position;
                    end[lines] = p5.transform.position;
                    lastSelected = null;
                    lines++;
                }
            }
        }

        p1.transform.GetChild(0).gameObject.SetActive(false);
        p2.transform.GetChild(0).gameObject.SetActive(false);
        p3.transform.GetChild(0).gameObject.SetActive(false);
        p4.transform.GetChild(0).gameObject.SetActive(false);
        p5.transform.GetChild(0).gameObject.SetActive(false);

        if (lastSelected != null) { lastSelected.transform.GetChild(0).gameObject.SetActive(true); }
        

        for (int i = 0; i < lines; i++)
        {
            lineDrawer[i].GetComponent<PentagramLines>().CreateLine(start[i], end[i]);
        }

        if (lines >= 5)
        {
            for (int i = 0; i < 5; i++)
            {
                if (((start[i] == p1.transform.position) && (end[i] == p4.transform.position)) || ((start[i] == p4.transform.position) && (end[i] == p1.transform.position)))
                {
                    l1 = true;
                }
                if (((start[i] == p1.transform.position) && (end[i] == p5.transform.position)) || ((start[i] == p5.transform.position) && (end[i] == p1.transform.position)))
                {
                    l2 = true;
                }
                if (((start[i] == p2.transform.position) && (end[i] == p3.transform.position)) || ((start[i] == p3.transform.position) && (end[i] == p2.transform.position)))
                {
                    l3 = true;
                }
                if (((start[i] == p4.transform.position) && (end[i] == p3.transform.position)) || ((start[i] == p3.transform.position) && (end[i] == p4.transform.position)))
                {
                    l4 = true;
                }
                if (((start[i] == p5.transform.position) && (end[i] == p2.transform.position)) || ((start[i] == p2.transform.position) && (end[i] == p5.transform.position)))
                {
                    l5 = true;
                }
            }
            if (l1 && l2 &&  l3 && l4 && l5 && !completed)
            {
                Debug.Log("WIN");
                p1.GetComponent<Animator>().enabled = true;
                p1.GetComponent<SpriteRenderer>().color = Color.white;
                p1.transform.position = new Vector3(p1.transform.position.x, p1.transform.position.y + 0.2f, p1.transform.position.z);

                p2.GetComponent<Animator>().enabled = true;
                p2.GetComponent<SpriteRenderer>().color = Color.white;
                p2.transform.position = new Vector3(p2.transform.position.x, p2.transform.position.y + 0.2f, p2.transform.position.z);

                p3.GetComponent<Animator>().enabled = true;
                p3.GetComponent<SpriteRenderer>().color = Color.white;
                p3.transform.position = new Vector3(p3.transform.position.x, p3.transform.position.y + 0.2f, p3.transform.position.z);

                p4.GetComponent<Animator>().enabled = true;
                p4.GetComponent<SpriteRenderer>().color = Color.white;
                p4.transform.position = new Vector3(p4.transform.position.x, p4.transform.position.y + 0.2f, p4.transform.position.z);

                p5.GetComponent<Animator>().enabled = true;
                p5.GetComponent<SpriteRenderer>().color = Color.white;
                p5.transform.position = new Vector3(p5.transform.position.x, p5.transform.position.y + 0.2f, p5.transform.position.z);

                baphomet.GetComponent<SpriteRenderer>().enabled = true;

                completed = true;

            }
            else if (completed == true)
            {
                GlobalVariableManager.solvedPuzzle5 = true;
            }
            else
            {
                Debug.Log("LOSE!");
                start = new Vector3[5];
                end = new Vector3[5];
                lines = 0;
                lastSelected = null;
                l1 = false;
                l2 = false;
                l3 = false;
                l4 = false;
                l5 = false;
                for (int i = 0; i < 5; i++)
                {
                    Destroy(lineDrawer[i]);
                }
                lineDrawer = new GameObject[5];
            }
        }
    }
}

