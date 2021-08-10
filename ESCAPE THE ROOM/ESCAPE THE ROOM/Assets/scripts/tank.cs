//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class tank : MonoBehaviour
//{
//    public GameObject cube;
//    public GameObject human;
//    public Animator stickDown;
//    public AudioClip enterSound;
//    public GameObject Chassis;
//    private static object clip;


//    private void Start()
//    {
//        cube.GetComponent<Animator>();
//    }
//    private void OnTriggerEnter(Collider other)
//    {
//        if (human.gameObject.CompareTag("human"))
//        {
//            stickDown.SetBool("tank", true);
//            AudioSource.PlayClipAtPoint(enterSound, transform.position);
//            tank.Play();
//Destroy(gameObject, tank.clip.length);

//        }

//    }

//    private void Destroy(GameObject gameObject, object length)
//    {
//        throw new NotImplementedException();
//    }

//    private static void Play()
//    {
//        throw new NotImplementedException();
//    }
//}