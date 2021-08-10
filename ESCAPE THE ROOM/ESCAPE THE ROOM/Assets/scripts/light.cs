using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour  
{
    //public GameObject human;
    public Light lightRed;
    public GameObject human;
    public AudioClip enterSound;
    public int i = 0; // Это же можно заменить на bool i = false;
    public GameObject Bow;
    public GameObject LongbowPreview;
    public GameObject poddon;



    private void Start()
    {
        lightRed.GetComponent<Light>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (human.gameObject.CompareTag("human") && i != 1) // i == false
        {
            i++; // i == true;
            lightRed.enabled = true;
            AudioSource.PlayClipAtPoint(enterSound, transform.position);
            Destroy(LongbowPreview,0f);
            Destroy(poddon, 0f);

            
        }
    }

    private void Destroy(object LongbowPreview)
    {
        throw new NotImplementedException();
    }
} 