using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinGen : MonoBehaviour
{
    public GameObject Coin;
    int count = 0;
    GameObject[] CoinArr = new GameObject[20];
    // Start is called before the first frame update
    void Start()
    {
        
        while (count < 5)
        {
            CoinArr[count] = Instantiate(Coin) as GameObject;
            CoinArr[count].transform.position = new Vector3(Random.Range(-3.3f, 3.8f), 0.5f, Random.Range(-3.1f, 3.4f));
            count++;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
