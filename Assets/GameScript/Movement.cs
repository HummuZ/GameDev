using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public float forward_speed = 0.01f;
    float up_speed = 0.01f ;
    

    public float move_speed = 0.01f;
    public float rotation_speed = 0.03f;
  




    // Start is called before the first frame update
    void Start()
    {
        up_speed = forward_speed / 3;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        // static forward
        //transform.position += new Vector3(0, 0, speed);
        // transform.position += new Vector3(0, 0, move_speed);
   
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position += transform.forward * speed * Time.deltaTime;
            transform.position += new Vector3(move_speed, 0, 0) ;
            

        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += transform.forward * speed * Time.deltaTime;
            transform.position += new Vector3(-move_speed, 0, 0) ;
            
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.position += transform.forward * speed * Time.deltaTime;
            transform.position += new Vector3(0, up_speed, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.position += transform.forward * speed * Time.deltaTime;
            transform.position += new Vector3(0, -up_speed, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-180f, 90f, 0f), rotation_speed *Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 90f, 0f), rotation_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90f, 90f, 0f), rotation_speed * Time.deltaTime);
        }


      
}



 
    
}