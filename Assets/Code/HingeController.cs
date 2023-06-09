using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeController : MonoBehaviour
{
    HingeJoint h;
    bool hasJoint;
    // Start is called before the first frame update
    void Start()
    {
        hasJoint = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 batToBatter = new Vector3(694.7f, 4, -182.5f) - transform.position;
        float zRadian = transform.rotation.eulerAngles.z * Mathf.PI / 180;
        if (Input.GetMouseButtonDown(0)&&!hasJoint)
        {
            hasJoint=true;
            gameObject.AddComponent<HingeJoint>();
            h = GetComponent<HingeJoint>();
            h.anchor = batToBatter;
            h.axis = new Vector3(Mathf.Sin(zRadian), Mathf.Cos(zRadian), 0);
            var motor = h.motor;
            motor.force = 120;
            motor.targetVelocity = 120;
            motor.freeSpin = false;
            h.motor = motor;
            h.useMotor = true;
        }
    }
}
