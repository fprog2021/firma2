using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageBox : MonoBehaviour
{

    private GameObject MessageSign;
    private Text MessageText;
    private BoxCollider bc;
    private Rigidbody rb;
    public string[] texts;
    public int messagesShown = 0;
    bool messageShown = false;

    void Awake()
    {
        MessageSign = GameObject.Find("MessageBox");
        MessageText = GameObject.Find("MessageText").GetComponent<Text>();
    }

    void Start()
    {
        MessageSign.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            ShowMessageBox();
    }

    public void ShowMessageBox()
    {
        MessageSign.SetActive(true);
        MessageText.text = texts[messagesShown];
        MessageText.enabled = true;
        messageShown = true;
    }

    public void Accept()
    {
        if (messageShown)
        {
            hideMessageBox();
            messagesShown++;
            if (messagesShown < texts.Length)
            {
                ShowMessageBox();
            }
            else
                Destroy(gameObject);
        }
    }

    public void hideMessageBox()
    {
        MessageSign.SetActive(false);
        MessageText.enabled = false;
        messageShown = false;
    }
}