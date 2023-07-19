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
    public GameObject start_button;
    public GameObject reset_button;
    Vector3 start_button_pos
    Vector3 start_button_scale;
    Vector3 reset_button_scale;
    public static UI inst;
    // Start is called before the first frame update
    void Start()
    {
        if (inst == null)
        {
            inst = this;
        }
        start_button_pos = start_button.transform.position;
        reset_button.transform.localScale = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (st)
        {
            timer += Time.deltaTime;

            ScoreText.SetText("Score: " + Movement.inst.Score.ToString());
            TimerText.SetText("Time: " + timer.ToString("#.#"));

        }
        if (Movement.inst.reset_btn)
        {

            reset_button.transform.position = start_button.transform.position;
            reset_button.transform.localScale = start_button.transform.localScale;

        }
    }
    public void StartBTN()
    {
       
        st = true;
        
        
    }
    public void ResetBTN()
    {

        st = true;


    }

}
