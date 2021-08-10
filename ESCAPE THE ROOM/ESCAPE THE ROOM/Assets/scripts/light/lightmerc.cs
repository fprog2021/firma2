using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightmerc : MonoBehaviour
{
    private float constInsten = 2;
    private float insten;
    private float Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 1.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Light>().intensity != constInsten) gameObject.GetComponent<Light>().intensity = constInsten;
        if (Timer > 0) Timer -= Time.deltaTime;
        if (Timer < 0) Timer = 0;
        if (Timer == 0)
        {
            insten = Random.Range(0, 2);
            gameObject.GetComponent<Light>().intensity = insten;
            Timer = Random.Range(0.1f, 0.6f);
        }


    }
}
