using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20;
    public float turnSpeed=0;
    public float horizontalInput=0;
    public float forwardInput=0;
    public GameObject pleyer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

       transform.Translate(Vector3.forward * Time.deltaTime * speed* forwardInput*2);
       
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        if (Input.GetKey(KeyCode.S) == true)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed / 2);
        }
    }
   }
