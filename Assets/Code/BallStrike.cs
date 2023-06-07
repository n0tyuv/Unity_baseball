using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStrike : MonoBehaviour
{
    private Camera MAIN;
    private Camera IP;
    private Camera OUTCAM;
    private Camera BHCAM;
    private Camera XBHCAM;
    private Camera HRCAM;
    private Camera FOULCAM;
    private Camera STRIKECAM;
    private Camera BALLCAM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onColliderEnter(Collider c)
    {
        if (c.gameObject.name.Contains("STRIKEZONE"))
        {

            MAIN.enabled = false;
            IP.enabled = false;
            STRIKECAM.enabled = true;
            System.Threading.Thread.Sleep(1000);
            STRIKECAM.enabled = false;
            MAIN.enabled = true;
        }
    }


}
