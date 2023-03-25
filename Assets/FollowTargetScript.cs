using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FollowTargetScript : MonoBehaviour
{
	public Transform target;
	public float length;

	private Vector3 startPosition;
	private Vector3 direction;

	private void Start()
	{
		startPosition = transform.position;
		direction = target.position - startPosition;
	}

	private void Update()
	{
		target = TowerToolScript.target.transform;
		Vector3 newPosition = target.position - direction.normalized * length;
		transform.position = new Vector3(newPosition.x, newPosition.y, startPosition.z);
	}
}
