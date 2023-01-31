using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(100*Input.GetAxisRaw("RightStickHorizontal") * Time.deltaTime,0,-100*Input.GetAxisRaw("RightStickVertical") * Time.deltaTime);
        //transform.Rotate(0,200*Input.GetAxisRaw("RightStickHorizontal")*Time.deltaTime,0);
        if (Input.GetAxisRaw("RightStickHorizontal") != 0 && Input.GetAxisRaw("RightStickVertical") != 0)
        {
            Vector3 direction = Vector3.right * Input.GetAxisRaw("RightStickHorizontal") + Vector3.back * Input.GetAxisRaw("RightStickVertical");
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}
