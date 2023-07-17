using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UI : MonoBehaviour
{
    public TMP_Text ScoreText;
    public TMP_Text TimerText;
    public bool st = false;
    float timer = 0;
    public GameObject Coin;
    public static UI inst;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CoinCreate", 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (st)
        {
            timer += Time.deltaTime;

            ScoreText.SetText("Score: " + Player.inst.Score.ToString());
            TimerText.SetText("Time: " + timer.ToString("#.#"));

        }
    }
    public void StartBTN()
    {
        st = true;
        Player.inst.speed = Player.inst.speedRun;
    }
    public void CoinCreate()
    {
        if (st)
        {
            GameObject c = Instantiate(Coin) as GameObject;
            c.transform.position = new Vector3(Random.Range(-3.3f, 3.8f), 0.5f, Random.Range(-3.1f, 3.4f));
        }
    }
}
