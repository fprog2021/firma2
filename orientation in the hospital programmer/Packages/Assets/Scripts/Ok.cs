using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ok : MonoBehaviour
{
    public GameObject panel;
    public GameObject button;
    public GameObject cube2;
    public void load()
    {   
        panel.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
        cube2.gameObject.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
