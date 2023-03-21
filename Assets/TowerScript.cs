using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
	[SerializeField] Transform CreateTool;
	bool isTower, isOpen;

	private void Start()
	{
		isTower = false;
		isOpen = false;
	}


	public void OpetCreateTool()
	{
		if (!isTower)
		{
			isOpen = !isOpen;
			CreateTool.gameObject.SetActive(isOpen);
		}
	}
}
