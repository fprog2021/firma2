using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
	public int numb;
	public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene(numb);
	}
	public void Exit()
	{
		Application.Quit();
	}
}