using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentSplit : MonoBehaviour
{

    private bool broken = false;


    void Start()
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (!broken)
            StartCoroutine(Wait());
        Checking();

    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(10);// Ждем 10 секунд
        DestroyObjectTime();
    }

    void Checking()
    {

        RaycastHit hit;
        Debug.DrawRay(transform.position, -transform.forward * .35f);

        if (Physics.Raycast(transform.position, -transform.forward, out hit))
        {
            if (hit.rigidbody && hit.rigidbody.isKinematic != true)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                broken = true;

            }

        }


    }

    Color _color;
    float step = 1;
    private float duration = 1.0f;
    void DestroyObjectTime()
    {

        var renderer = this.gameObject.GetComponent<Renderer>();
        _color = renderer.material.color;
        if (_color.a > 0)
        {

            _color.a = step-- * Time.time * duration;
            renderer.material.color = _color;
        }
        else { return; }
        if (_color.a < 1)
        {

            // Kills the game object in 5 seconds after loading the object
            Destroy(this.gameObject, 5);
        }

    }


    void OnCollisionEnter(Collision collision)
    {

        if (collision.relativeVelocity.magnitude < 1.5f)
            return;

        if (collision.transform.gameObject.layer != LayerMask.NameToLayer("Fragment"))
        {
            GetComponent<Rigidbody>().isKinematic = false;
        }

    }


}