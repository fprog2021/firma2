    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//public class control_points : MonoBehaviour
//{
//    int CountChildObjectsByTag(GameObject parent, string tag)
//    {
//        GameObject currentMain = GameObject.FindGameObjectWithTag("MainCamera");
//        int childCount = CountChildObjectsByTag(currentMain, "High");
//        foreach (Transform child in parent.transform)
//        {
//            if (child.CompareTag(tag))
//                childCount++;
//        }
//        return childCount;
//    }
//}

public class control_points : MonoBehaviour
{
    public int numb;
    public bool stolknulsya = false;
    public GameObject button1;
    public GameObject panel;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
       
            gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
           // gameObject.GetComponent<BoxCollider>().isTrigger = true;
            //Destroy(gameObject.GetComponent<BoxCollider>());
            
    }

    // Update is called once per frame
    void Update()
    {
        if (stolknulsya)
        {
            
            stolknulsya = false;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            other.gameObject.SetActive(false);

            panel.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
            //SceneManager.LoadScene("1");
        }
        if (other.gameObject.CompareTag("Finish1"))
        {
            other.gameObject.SetActive(false);

            panel.gameObject.SetActive(true);
            button1.gameObject.SetActive(true);
            SceneManager.LoadScene("1");
        }
    }

}

