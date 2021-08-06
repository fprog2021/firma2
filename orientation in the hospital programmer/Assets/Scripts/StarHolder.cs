using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarHolder : MonoBehaviour
{

    public List<GameObject> ListStars = new List<GameObject>();
    public GameObject Father;
    public bool onoff = true;
    public float TimeDela;

    void Start()
    {
        StartCoroutine(GeneratingStar()); //Запуск коротина
    }

    void Update()
    {

    }
    public IEnumerator GeneratingStar()
    {
        TimeDela = Random.Range(3f, 10f);

        foreach (Transform item in Father.transform)
        {
            ListStars.Add(item.gameObject);
            if (!item.gameObject.activeSelf)
            {
                item.gameObject.SetActive(true);            //Для линейного включения
                yield return new WaitForSeconds(TimeDela);
            }
        }
        //  foreach(GameObject item in ListStars){
        //  ListStars [Random.Range (0, ListStars.Count)].SetActive (true); //Для рандомного включения
        //  yield return new WaitForSeconds(TimeDela); 
        //}
    }
}