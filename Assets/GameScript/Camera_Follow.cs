using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera_Follow : MonoBehaviour
{
    /*
    public Transform player;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 0.8f, -2f);
        
    }*/

    public Transform target;


    float smoothSpeed = 2f;

    private void Start()
    {
       
    }

    private void LateUpdate()
    {
        SmoothFollow();
    }

    public void SmoothFollow()
    {
        Vector3 targetPos = target.position + new Vector3(0, 0.8f, -2f);
        Vector3 smoothFollow = Vector3.Lerp(transform.position, targetPos, smoothSpeed);

        transform.position = smoothFollow;
      
    }
}
