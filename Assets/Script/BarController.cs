using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    public float speed = 10f;

    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity =new Vector3(Input.GetAxis("Bar")*speed,0f,0f);
    }
}
