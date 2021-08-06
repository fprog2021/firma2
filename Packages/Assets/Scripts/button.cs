using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class button : MonoBehaviour
{

	public void OnClick() // пустой тип данных
	{
		Debug.Log("клик");

	}


	bool Pressed = false;
	public void onDown()
	{
		Pressed = true;
	}

	public void onUp()
	{
		Pressed = false;
	}

	void Update()
	{
		if (Pressed) Debug.Log("Кнопка нажата");
	}
}