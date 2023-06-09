using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject cam7;
    public GameObject cam8;
    public GameObject cam9;
    private float time;
    private bool timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = false;
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam7.SetActive(false);
        cam8.SetActive(false);
        cam9.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<0.5&&(transform.position.x + transform.position.z < 851.1 || transform.position.x + transform.position.z > 895.6))
        {
            if (!timer)
            {
                time = Time.realtimeSinceStartup;
                timer = true;
            }
            cam1.gameObject.SetActive(false);
            cam9.gameObject.SetActive(true);
            if (Time.realtimeSinceStartup - time > 1)
            {
                cam9.gameObject.SetActive(false);
                cam1.gameObject.SetActive(true);
                timer = false; 
            }
            

        }
        else if (transform.position.y < 0.5 && transform.position.z < 51.5)
        {
            if (Random.Range(0, 100) > 15)
            {

                if (!timer)
                {
                    time = Time.realtimeSinceStartup;
                    timer = true;
                }
                cam1.gameObject.SetActive(false);
                cam3.gameObject.SetActive(true);
                if (Time.realtimeSinceStartup - time > 1)
                {
                    cam3.gameObject.SetActive(false);
                    cam1.gameObject.SetActive(true);
                    timer = false;
                }
            }
            else
            {
                if (!timer)
                {
                    time = Time.realtimeSinceStartup;
                    timer = true;
                }
                cam1.gameObject.SetActive(false);
                cam4.gameObject.SetActive(true);
                if (Time.realtimeSinceStartup - time > 1)
                {
                    cam4.gameObject.SetActive(false);
                    cam1.gameObject.SetActive(true);
                    timer = false;
                }
            }

        }
        else
        {
            if (Random.Range(0, 100) > 20)
            {
                if (!timer)
                {
                    time = Time.realtimeSinceStartup;
                    timer = true;
                }
                cam1.gameObject.SetActive(false);
                cam3.gameObject.SetActive(true);
                if (Time.realtimeSinceStartup - time > 1)
                {
                    cam3.gameObject.SetActive(false);
                    cam1.gameObject.SetActive(true);
                    timer = false;
                }
            }
            else
            {
                if (!timer)
                {
                    time = Time.realtimeSinceStartup;
                    timer = true;
                }
                cam1.gameObject.SetActive(false);
                cam5.gameObject.SetActive(true);
                if (Time.realtimeSinceStartup - time > 1)
                {
                    cam5.gameObject.SetActive(false);
                    cam1.gameObject.SetActive(true);
                    timer = false;
                }
            }
        }
    }
    void onColliderEnter(Collider c)
    {
        if (c.gameObject.name.Contains("Fence"))
        {
            if (transform.position.x + transform.position.z < 851.1 || transform.position.x + transform.position.z > 895.6)
            {
                if (!timer)
                {
                    time = Time.realtimeSinceStartup;
                    timer = true;
                }
                cam1.gameObject.SetActive(false);
                cam9.gameObject.SetActive(true);
                if (Time.realtimeSinceStartup - time > 1)
                {
                    cam9.gameObject.SetActive(false);
                    cam1.gameObject.SetActive(true);
                    timer = false;
                }

            }
            else
            {
                if (!timer)
                {
                    time = Time.realtimeSinceStartup;
                    timer = true;
                }
                cam1.gameObject.SetActive(false);
                cam6.gameObject.SetActive(true);
                if (Time.realtimeSinceStartup - time > 1)
                {
                    cam6.gameObject.SetActive(false);
                    cam1.gameObject.SetActive(true);
                    timer = false;
                }
            }

        }
    }
}
