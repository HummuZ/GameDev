using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot : MonoBehaviour
{
    Animator botAnim;
    // Start is called before the first frame update
    void Start()
    {
        botAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            botAnim.SetTrigger("run");
             
        }
        else
        {
            botAnim.SetTrigger("idle");
        }
        
    }
}
