using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SnowMan : MonoBehaviour
{
    public float speed = 0.01f;
    public float rotate = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // static forward
        //transform.position += new Vector3(0, 0, speed);
       
       

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position += transform.forward * speed * Time.deltaTime;
            transform.position += new Vector3(speed, 0, 0);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += transform.forward * speed * Time.deltaTime;
            transform.position += new Vector3(-speed, 0, 0);

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.position += transform.forward * speed * Time.deltaTime;
            transform.position += new Vector3(0, speed, 0);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.position += transform.forward * speed * Time.deltaTime;
            transform.position += new Vector3(0,-speed,0);

        }

       
    }
    
}



