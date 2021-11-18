using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    private int sec = 0;
    public Text timerText;
    public Button resetButton;


    void Start()
    {
        StartCoroutine(TimeFlow());        
    }


    IEnumerator TimeFlow()
    {
        while (true)
        {
            sec++;
            timerText.text = sec.ToString();
            yield return new WaitForSeconds(1);
        }
    }


    public void resetTimer()
    {
        sec = 0;
        timerText.text = sec.ToString();
    }
}
