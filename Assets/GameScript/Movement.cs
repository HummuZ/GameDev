using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    float forward_speed = 0.05f;
    float up_speed = 0.005f;

    public int Score = 0;
    float move_speed = 0.1f;
    float rotation_speed = 10f;
    int lvlcount = 1;
    public static Movement inst;
    float reset_pos;
    public GameObject lvl;
    
    public bool reset_btn;

    // Start is called before the first frame update
    void Start()
    {
        if (inst == null)
        {
            inst = this;
        }
        up_speed = forward_speed / 5;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UI.inst.st)
        {
            reset_pos = Mathf.Floor(transform.position.z);
            // static forward
            //transform.position += new Vector3(0, 0, speed);
            transform.position += new Vector3(0, 0, forward_speed + (Time.deltaTime));

            if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x < 9))
            {
                //transform.position += transform.forward * speed * Time.deltaTime;
                transform.position += new Vector3(forward_speed + (Time.deltaTime) / 12, 0, 0);


            }

            if (Input.GetKey(KeyCode.LeftArrow) && (transform.position.x > -18))
            {
                //transform.position += transform.forward * speed * Time.deltaTime;
                transform.position += new Vector3(-forward_speed + (Time.deltaTime) / 12, 0, 0);

            }

            if (Input.GetKey(KeyCode.UpArrow) && (transform.position.y < 4))
            {
                //transform.position += transform.forward * speed * Time.deltaTime;
                transform.position += new Vector3(0, up_speed, 0);
            }

            if (Input.GetKey(KeyCode.DownArrow) && (transform.position.y > 0.5f))
            {
                //transform.position += transform.forward * speed * Time.deltaTime;
                transform.position += new Vector3(0, -up_speed, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-180f, 90f, 0f), rotation_speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 90f, 0f), rotation_speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90f, 90f, 0f), rotation_speed * Time.deltaTime);
            }

            if(reset_pos%150 == 0)
            {
                lvlcount++;
                GameObject lvl1 = Instantiate(lvl) as GameObject;
                lvl1.transform.position = new Vector3(0,0, 200*lvlcount);
            }
        }
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "cube")
        {
            Score++;
          
            Destroy(collision.gameObject);


        }
        if (collision.gameObject.tag == "wall")
        {
            UI.inst.st=false;
            reset_btn = true;
           
        }
    }





}