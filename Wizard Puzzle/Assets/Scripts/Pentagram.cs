using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pentagram : MonoBehaviour
{
    public GameObject p1, p2, p3, p4, p5;
    GameObject lastSelected;
    Vector3[] start, end;
    int lines;
    bool l1, l2, l3, l4, l5;
    void Start()
    {
        start = new Vector3[5];
        end = new Vector3[5];
        lines = 0;
        lastSelected = null;
        l1 = false;
        l2 = false;
        l3 = false;
        l4 = false;
        l5 = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
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
                start[lines] = lastSelected.transform.position;
                end[lines] = p1.transform.position;
                lastSelected = null;
                lines++;
            }    
        }

        if (Input.GetKeyDown(KeyCode.A))
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
                start[lines] = lastSelected.transform.position;
                end[lines] = p2.transform.position;
                lastSelected = null;
                lines++;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
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
                start[lines] = lastSelected.transform.position;
                end[lines] = p3.transform.position;
                lastSelected = null;
                lines++;
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
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
                start[lines] = lastSelected.transform.position;
                end[lines] = p4.transform.position;
                lastSelected = null;
                lines++;
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
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
                start[lines] = lastSelected.transform.position;
                end[lines] = p5.transform.position;
                lastSelected = null;
                lines++;
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
            Debug.DrawLine(start[i], end[i], Color.red);
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
            if (l1 && l2 &&  l3 && l4 && l5)
            {
                SceneManager.LoadScene("WIN");
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
            }
        }
    }
}
