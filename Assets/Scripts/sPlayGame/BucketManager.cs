using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketManager : MonoBehaviour {
	
    // Use this for initialization
    public float speed;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float moveInput = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveInput = 5 * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveInput = -5 * Time.deltaTime;
        }

        transform.position += new Vector3(moveInput, 0, 0);

        //Restrict movement between two values
        if (transform.position.x <= -2.5f || transform.position.x >= 2.5f)
        {
            float xPos = Mathf.Clamp(transform.position.x, -2.5f, 2.5f); //Clamp between min -2.5 and max 2.5
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }
    }
   
	
	// Update is called once per frame
	void Update () {
		runBucket ();
	}
	void runBucket(){

		//Restrict movement between two values
		if (transform.position.x <= -2.5f || transform.position.x >= 2.5f)
		{
			float xPos = Mathf.Clamp(transform.position.x, -2.5f, 2.5f); //Clamp between min -2.5 and max 2.5
			transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
		}
	}

}
