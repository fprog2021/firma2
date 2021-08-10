using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class richag : MonoBehaviour
{
    public Animator manipulator;
    public AudioClip muzuka;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("moveRight"))
        {
         
            manipulator.enabled = true;
            manipulator.SetBool("u", true);
            AudioSource.PlayClipAtPoint(muzuka, transform.position);
        }
        else if(other.gameObject.CompareTag("moveLeft"))
        {
            manipulator.enabled = true;
            manipulator.SetBool("u", true);
            AudioSource.PlayClipAtPoint(muzuka, transform.position);
        }
        
    }
}
