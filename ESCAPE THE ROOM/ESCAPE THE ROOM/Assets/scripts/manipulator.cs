using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manipulator : MonoBehaviour
{
    public Animator start;
    public AudioClip muzik;
    private void Start()
    {
        //cube.GetComponent<Animator>();
    }
    
    public void sfadsfas()
    {
        start.enabled = true;
        AudioSource.PlayClipAtPoint(muzik, transform.position);
    }
}