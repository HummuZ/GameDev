using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float speed = 0;
    public float Distance = 0.1f;
    public float speedRun = 0.01f;


    public static Player inst;
    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(inst == null){
            inst=this;
        }
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                //transform.position += transform.forward * speed * Time.deltaTime;
                transform.position += new Vector3(0,0, speed);

            }

            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                //transform.position += transform.forward * speed * Time.deltaTime;
                transform.position += new Vector3(0, 0, -speed);

        }

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                //transform.position += transform.forward * speed * Time.deltaTime;
                transform.position += new Vector3(speed, 0, 0);

        }

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                //transform.position += transform.forward * speed * Time.deltaTime;
                transform.position += new Vector3(-speed, 0, 0);

        }
        }
    private void OnCollisionEnter(Collision collision) { 
   
        if (collision.gameObject.tag == "Coin")
        {
            Score++;
          
            Destroy(collision.gameObject);
            
      
        }
    }
}
   
    

