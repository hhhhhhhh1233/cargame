using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        anchor = GameObject.Find("Anchor");
    }
    public GameObject anchor;
    

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(anchor.transform.position, Vector3.up, Input.GetAxisRaw("RightStickHorizontal") * 100 * Time.deltaTime);
    }
}
