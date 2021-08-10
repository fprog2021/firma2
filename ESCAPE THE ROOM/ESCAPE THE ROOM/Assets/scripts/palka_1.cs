using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palka_1 : MonoBehaviour
{
    public GameObject cube;
    public GameObject human;
    public Animator stick;
    public AudioClip enterSound;


    private void Start()
    {
        //cube.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("human"))
        {
            Debug.Log("ploxo");
            stick.enabled = true;
            stick.SetBool("stick", true);
            AudioSource.PlayClipAtPoint(enterSound, transform.position);
            Destroy(gameObject, 3f);
        }

    }
}