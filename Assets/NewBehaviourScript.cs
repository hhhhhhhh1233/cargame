using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
	float horizontalInput = Input.GetAxis("Horizontal");
	float triggerInput = Input.GetAxis("Accelerate");


	transform.Rotate(0,120*horizontalInput*Time.deltaTime,0);

	//transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);

	transform.position += 10 * triggerInput * transform.forward * Time.deltaTime;

	if (Input.GetButton("Fire1"))
	{
		transform.position += 10 * transform.forward * Time.deltaTime;
	}
	if (Input.GetButton("Fire2"))
	{
		transform.position += -5 * transform.forward * Time.deltaTime;
	}
    }
}