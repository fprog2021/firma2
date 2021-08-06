using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioFin : MonoBehaviour
{
    public AudioSource sfx_point;



    private void Start()
    {
        sfx_point = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "finish")
        {
            sfx_point.Play();
        }

    }
}