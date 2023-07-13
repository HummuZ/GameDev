using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UI : MonoBehaviour
{
    public TMP_Text ScoreText;
    public TMP_Text TimerText;
    float timer = 0;
    int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        ScoreText.SetText(Player.inst.Score.ToString());
        TimerText.SetText(timer.ToString("#.#"));


    }

}
