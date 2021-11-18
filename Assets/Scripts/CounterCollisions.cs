using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterCollisions: MonoBehaviour
{

    public int counter;
    public Text countText;
    public Button buttonReset;
    private bool flag;


    private void Start()
    {
        StartCoroutine(TimeFlow());
    }


    private void OnCollisionEnter(Collision collision)
    {
        flag = true;
    }


    IEnumerator TimeFlow()
    {
        while (true)
        {
            if (flag)
            {
                counter++;
                flag = false;
                countText.text = counter.ToString();
            }
            yield return new WaitForFixedUpdate();
        }
    }


    public void ResetCounter()
    {
        counter = 0;
        countText.text = counter.ToString();
    }
}