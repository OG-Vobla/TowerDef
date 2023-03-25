using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TowerToolScript : MonoBehaviour
{
	[SerializeField] Transform CreateTool;
	[SerializeField] List<GameObject> Towers;
	[SerializeField] List<GameObject> Bullets;
	public static GameObject target = null;
	bool isTower, isOpen;
	int towerNum;

	private void Start()
	{
		isTower = false;
		isOpen = false;
	}

	private void Update()
	{
		if (isTower)
		{

		}
	}

	public void OpenCreateTool()
	{
		if (!isTower)
		{
			isOpen = !isOpen;
			CreateTool.gameObject.SetActive(isOpen);
		}
	}
	public void CreateTower(int newTowerNum)
	{
		if (!isTower)
		{
			towerNum = newTowerNum;
			isOpen = false;
			CreateTool.gameObject.SetActive(isOpen);
			isTower = true;
			Towers[towerNum].SetActive(true);
			StartCoroutine(Shooting());
		}
	}

	public IEnumerator Shooting()
	{
		while (true)
		{
			if (target != null)
			{

/*				float distance = Mathf.Sqrt((Mathf.Pow((transform.position.x - target.transform.position.x), 2) + Mathf.Pow((transform.position.y - target.transform.position.y), 2)));
				Bullets[towerNum].transform.localScale = new Vector2(1, distance );*/

				Bullets[towerNum].SetActive(true);
				yield return new WaitForSeconds(0.5f);
				Bullets[towerNum].SetActive(false);
			}
			yield return new WaitForSeconds(2);
		}

	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (target == collision.gameObject)
		{
			target = null;
		}
	}
	private void OnTriggerStay2D(Collider2D collision)
	{
		if (target == null)
		{
			Debug.Log("sdfgsd");
			target = collision.gameObject;
		}
	}

}
