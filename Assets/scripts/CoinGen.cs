using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinGen : MonoBehaviour
{
    public GameObject Coin;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        while (count < 5)
        {
            GameObject c = Instantiate(Coin) as GameObject;
            c.transform.position = new Vector3(Random.Range(-3.3f, 3.8f), 0.5f, Random.Range(-3.1f, 3.4f));
            count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
