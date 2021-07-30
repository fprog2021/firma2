using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Timer2 : MonoBehaviour
{
    public float miliSecond;
    public float second;
    public float minute;
    public Text text;
    private void FixedUpdate()
    {

        miliSecond += 0.2f;
        if (miliSecond >= 1)
        {
            second++;
            miliSecond = 0;
        }
        if (second == 60)
        {
            minute++;
            second = 0;
        }

        text.text = $"{minute} : {second}";
    }
}

