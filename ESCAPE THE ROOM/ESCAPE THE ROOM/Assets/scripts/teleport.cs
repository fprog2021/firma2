using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour
{
    public AudioClip musik;
    public int i = 0;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player") && i != 1) ;
        {
            i++;
            collision.gameObject.transform.position = new Vector3((float)-10.318, (float)10.053, (float)-26.64);
            AudioSource.PlayClipAtPoint(musik, transform.position);
        }

    }

}