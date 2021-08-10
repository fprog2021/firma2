using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forAnimation : MonoBehaviour {
    public GameObject cube;
    public GameObject human;
    public Animator stickDown;
    public AudioClip enterSound;

    private void Start()
    {
        //cube.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("dver"))
        {
            Debug.Log("ploxo");
            stickDown.enabled = true;
            stickDown.SetBool("downStick" , true);
            AudioSource.PlayClipAtPoint(enterSound, transform.position);
            Destroy(gameObject, 3f);
        }

    }   } 