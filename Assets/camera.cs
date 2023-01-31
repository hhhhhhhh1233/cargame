using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vehicle = GameObject.Find("Vehicle");
    }
    public GameObject Vehicle;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vehicle.transform.position + new Vector3(0, 15, -6);
    }
}
