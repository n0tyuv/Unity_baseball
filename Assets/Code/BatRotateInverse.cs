using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatRotateInverse : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}
	// Update is called once per frame
	void Update()
	{
		float vert = Input.GetAxis("Mouse Y");
		float horiz = Input.GetAxis("Mouse X");
		float zAngle;
		if (vert != 0)
		{
			transform.RotateAround(new Vector3(694.7f, 4f, -182.5f), Vector3.forward, -vert);
		}
		if (horiz != 0)
		{
			zAngle = transform.rotation.eulerAngles.z;
			transform.Translate(-horiz / 3 * Mathf.Cos(zAngle * Mathf.PI / 180), -horiz / 3 * Mathf.Sin(zAngle * Mathf.PI / 180), 0);
		}

		if (transform.position.x < 684.4)
		{
			transform.position = new Vector3(684.4f, transform.position.y, transform.position.z);
		}
		if (transform.position.x > 699.4)
		{
			transform.position = new Vector3(699.4f, transform.position.y, transform.position.z);
		}
		if (transform.rotation.z > 20)
		{
			transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 20f);
		}
		if (transform.rotation.z < -20)
		{
			transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -20f);
		}
		if (transform.position.y < 0)
		{
			transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
		}
		if (transform.position.y > 8)
		{
			transform.position = new Vector3(transform.position.x, 8f, transform.position.z);
		}
		if(Input.GetKeyDown(KeyCode.Mouse0))
        {
			Destroy(this);
        }
	}
}
