using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UI.inst.st)
        {
            transform.rotation *= Quaternion.Euler(-0.01f, 0, 0);
        }
    }
}
