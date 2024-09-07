using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 20.0f;
    private float turnspeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Move horizontal
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime); 
    }
}
