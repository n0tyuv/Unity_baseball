using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStrike : MonoBehaviour
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
    private bool strikeZone;
    public GameObject qwedsa;
    private float time;
    private bool timer;
    private bool swing;

   


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
        strikeZone = false;
        
    }

     //Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            swing = true;
        }
        if (strikeZone)
        {
            if (!timer)
            {
                time = Time.realtimeSinceStartup;
                timer = true;
            }
            cam1.gameObject.SetActive(false);
            cam7.gameObject.SetActive(true);
            if(Time.realtimeSinceStartup - time > 1)
            {
                cam7.gameObject.SetActive(false);
                cam1.gameObject.SetActive(true);
                timer = false;
                strikeZone = false;
                swing = false;
            }
            
        }
        
         else if (qwedsa.transform.position.z<-190)
        {
            if(swing)
            {
                strikeZone=true;
                
            }
            if (!timer)
            {
                time = Time.realtimeSinceStartup;
                timer = true;
            }
            cam1.gameObject.SetActive(false);
            cam8.gameObject.SetActive(true);
            if (Time.realtimeSinceStartup - time > 1)
            {
                cam8.gameObject.SetActive(false);
                cam1.gameObject.SetActive(true);
                timer = false;
            }
            qwedsa.transform.position = new Vector3(0, 0, 100000);
        }
    } 
        
    void onColliderEnter(Collider c)
    {
        if (c.gameObject.name.Contains("SZ"))
        {
            strikeZone = true;
        }
        Debug.Log(c.gameObject.name);
        
        
    } 
}