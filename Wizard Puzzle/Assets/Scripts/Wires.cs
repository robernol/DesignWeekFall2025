using UnityEngine;

public class Wires : MonoBehaviour
{
    public GameObject plugged, unplugged, s1, s2, s3, s4, s5;
    bool pluggedIn;
    void Start()
    {
        pluggedIn = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            pluggedIn = true;
            transform.position = new Vector3(s1.transform.position.x, s1.transform.position.y, -1);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            pluggedIn = true;
            transform.position = new Vector3(s2.transform.position.x, s2.transform.position.y, -1);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            pluggedIn = true;
            transform.position = new Vector3(s3.transform.position.x, s3.transform.position.y, -1);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            pluggedIn = true;
            transform.position = new Vector3(s4.transform.position.x, s4.transform.position.y, -1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            pluggedIn = true;
            transform.position = new Vector3(s5.transform.position.x, s5.transform.position.y, -1);
        }
        else
        {
            pluggedIn = false;
        }

        if (!pluggedIn)
        {
            transform.position = new Vector3(0, -3, -1);
            plugged.SetActive(false);
            unplugged.SetActive(true);
        }
        else
        {
            plugged.SetActive(true);
            unplugged.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!pluggedIn)
            {
                plugged.SetActive(true);
                unplugged.SetActive(false);
                pluggedIn = true;
                transform.position = new Vector3(s1.transform.position.x, s1.transform.position.y, -1);
            }
            else
            {
                plugged.SetActive(false);
                unplugged.SetActive(true);
                pluggedIn = false;
                transform.position = new Vector3(0, -3, -1);
            }
        }
    }
}
