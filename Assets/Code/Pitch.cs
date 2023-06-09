using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitch : MonoBehaviour
{
    Rigidbody r;
    public bool spacePressed;
    public bool broke;
    public float velo;

    private void Start()
    {
        spacePressed = false;
        r = GetComponent<Rigidbody>();
        broke = false;
        velo = Random.Range(80, 95);
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            r.AddForce(new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), -velo), ForceMode.VelocityChange);
            if (transform.position.z < -120 && !broke)
            {
                if (Random.Range(-1, 1) < 0)
                {
                    r.AddRelativeForce(new Vector3(Random.Range(-1, 1), Random.Range(-1.5f, 0.5f), 0), ForceMode.Impulse);
                }
                broke = true;
            }
        }

    }
}
