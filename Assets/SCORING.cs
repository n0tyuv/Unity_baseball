using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject WallTop;
    public GameObject MAIN;
    public GameObject IP;
    public GameObject BHCAM;
    public GameObject XBHCAM;
    public GameObject HRCAM;
    // Start is called before the first frame update
    void Start()
    {
        WallTop.isTrigger = true;


    }

    // Update is called once per frame\
    private void OnTriggerEnter(Wall Top)

    {
        MAIN.enabled = false;
        IP.enabled = false;
        BHCAM.enabled = false;
        XBHCAM.enabled = false;
        HRCAM.enabled = true;
        if ((transform.position.x + transform.position.z < 851.1 || transform.position.x + transform.position.z > 895.6)
        {
            FOUL - CAM.enabled = true;
            yield return new WaitForSeconds(5);
            FOUL - CAM.enabled = false;
            MAIN CAM.enabled = true;
        }
        Else
            { 
               HR - CAM.enabled = true;
            yield return new WaitForSeconds(5);
            HR - CAM.enabled = false;
            MAIN CAM.enabled = true;

            }


    }
    void Update()
    {
        if (transform.position.x + transform.position.z < 851.1 || transform.position.x + transform.position.z > 895.6)
            MAIN CAM.enabled = false;
            IP.enabled = false;
            FOUL - CAM.enabled = true;
            yield return new WaitForSeconds(5);
            FOUL - CAM.enabled = false;
            MAIN CAM.enabled = true;


        else if (transform.position.y < 0.5) {
            if (transform.position.z < 51.5) {
                If(Random.Range(0, 100) > 15) {

                    MAIN CAM.enabled = false;
                    IP.enabled = false;
                    OUT - CAM.enabled = true;
                    yield return new WaitForSeconds(5);
                    OUT - CAM.enabled = false;
                    MAIN CAM.enabled = true;
                }
            }
        }
		else
			MAIN CAM.enabled = false;
            IP.enabled = false;
			BH-CAM.enabled = true;
            yield return new WaitForSeconds(5);
            BH-CAM.enabled = false;
            MAIN CAM.enabled = true;
            else 	
            if(Random.Range(0,100) > 20)
			MAIN CAM.enabled = false;
            IP.enabled = false;
			OUT-CAM.enabled = true;
            yield return new WaitForSeconds(5);
            OUT-CAM.enabled = false;
            MAIN CAM.enabled = true;
         Else
             MAIN CAM.enabled = false;
			IP.enabled = false;
			XBH-CAM.enabled = true;
            yield return new WaitForSeconds(5);
            XBH-CAM.enabled = false;
            MAIN CAM.enabled = true;


}

    }
