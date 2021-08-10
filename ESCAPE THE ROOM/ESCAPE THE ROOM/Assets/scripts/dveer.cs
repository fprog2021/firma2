using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dveer : MonoBehaviour
{
    public GameObject dver;
    public GameObject human;
    public Animator GameObject;
    public AudioClip enterSound;
    public int i = 0; // Это же можно заменить на bool i = false;

    private void Start()
    {
        //cube.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("human") && i==0)
        {Debug.Log("ЪуЪ");
            i++;
            GameObject.enabled = true;
            GameObject.SetBool("human", true);
            AudioSource.PlayClipAtPoint(enterSound, transform.position);
            
        }

    }

   
}