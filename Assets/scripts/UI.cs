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


    // Start is called before the first frame update
    void Start()
    {
        
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
        Player.inst.speed = Player.inst.speedRun ;
    }
}
