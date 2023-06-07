using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Camera MAIN;
    private Camera IP;
    private Camera OUTCAM;
    private Camera BHCAM;
    private Camera XBHCAM;
    private Camera HRCAM;
    private Camera FOULCAM;


   

    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x + transform.position.z < 851.1 || transform.position.x + transform.position.z > 895.6)
        {
            MAIN.enabled = false;
            IP.enabled = false;
            FOULCAM.enabled = true;
            System.Threading.Thread.Sleep(1000);
            FOULCAM.enabled = false;
            MAIN.enabled = true;

        }
        else if(transform.position.y < 0.5 && transform.position.z < 51.5)
        {
            if(Random.Range(0, 100) > 15)
            {

                MAIN.enabled = false;
                IP.enabled = false;
                OUTCAM.enabled = true;
                System.Threading.Thread.Sleep(1000);
                OUTCAM.enabled = false;
                MAIN.enabled = true;
            }
            else
            {
                MAIN.enabled = false;
                IP.enabled = false;
                BHCAM.enabled = true;
                System.Threading.Thread.Sleep(1000);
                BHCAM.enabled = false;
                MAIN.enabled = true;
            }

        }
        else
        {
            if (Random.Range(0, 100) > 20)
            {
                MAIN.enabled = false;
                IP.enabled = false;
                OUTCAM.enabled = true;
                System.Threading.Thread.Sleep(1000);
                OUTCAM.enabled = false;
                MAIN.enabled = true;

            }
            else
            {
                MAIN.enabled = false;
                IP.enabled = false;
                XBHCAM.enabled = true;
                System.Threading.Thread.Sleep(1000);
                BHCAM.enabled = false;
                MAIN.enabled = true;
            }

        }
    }
    void onColliderEnter(Collider c)
    {
        if (c.gameObject.name.Contains("Fence"))
        {
            if (transform.position.x + transform.position.z < 851.1 || transform.position.x + transform.position.z > 895.6)
            {
                MAIN.enabled = false;
                IP.enabled = false;
                FOULCAM.enabled = true;
                System.Threading.Thread.Sleep(1000);
                FOULCAM.enabled = false;
                MAIN.enabled = true;

            }
            else
            {
                MAIN.enabled = false;
                IP.enabled = false;
                HRCAM.enabled = true;
                System.Threading.Thread.Sleep(1000);
                HRCAM.enabled = false;
                MAIN.enabled = true;
            }

        }
    }
}
