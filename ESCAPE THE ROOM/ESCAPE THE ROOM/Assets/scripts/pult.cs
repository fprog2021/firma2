using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pult : MonoBehaviour
{
    private bool estpult;
    //private bool estpult_manipulatora;
    public GameObject pult_full;
    public GameObject npult;
    public GameObject gm;
    
    private void Update()
    {
        if (estpult )/*estpult_manipulatora*/
        {
            delete();
        }
    }
    private void OnTriggerEnter(Collider other) // функция сопроикосновения коллайдеров 
    {
        /*if (other.gameObject.CompareTag("pult_manipulatora")); //  касемся манипулятора 
        {
            estpult_manipulatora = true;
        }*/
        if (other.gameObject.CompareTag("pult"))
        {
            estpult = true;
        }
    }
    void delete()
    {
        gm.SetActive(true);
        //Instantiate(pult_full, new Vector3(npult.gameObject.transform.position.x, npult.gameObject.transform.position.y, npult.gameObject.transform.position.z), Quaternion.Euler(0,180,270));
        Destroy(npult.gameObject);

        Destroy(this.gameObject);
        estpult = false;
        //estpult_manipulatora = false;
    }
}

 





    





















