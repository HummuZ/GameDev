using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{

    public float speed = 1f;
    Animator coinanim;
    bool swap;
    // Start is called before the first frame update
    void Start()
    {
        coinanim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation *= Quaternion.Euler(0,speed, 0);

        if (Input.GetKeyDown(KeyCode.Space)){
            if (swap)
            {
                coinanim.SetTrigger("scale1");
                swap = false;
            }
            else
            {
                coinanim.SetTrigger("scale");
                swap = true;
               
            }
        }
    }
}
