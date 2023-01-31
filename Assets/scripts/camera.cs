using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    void Start()
    {
        Vehicle = GameObject.Find("Vehicle");
    }
    public GameObject Vehicle;

    void Update()
    {
        transform.position = Vehicle.transform.position + new Vector3(0, 15, -6);
    }
}
