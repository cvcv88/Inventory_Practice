using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
	// ����� �ʿ��� NPC

	// [SerializeField] Inventory inven;
	[SerializeField] Inventory inven;
	[SerializeField] Item item;
	GameObject checkPlayer;

	private void Start()
	{

	}
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.X) && checkPlayer != null)
		{
			CheckItem();
		}
	}

	private void CheckItem()
	{
		if (inven.FindInven(checkPlayer.name))
		{
			inven.RemoveInven(checkPlayer.name);
			Debug.Log("NPC�� ����� �ް� �⻵�մϴ�.");
		}
		else
		{
			Debug.Log("�������� �����ϴ�.");
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.layer == 7) // Player
		{
			checkPlayer = collision.gameObject;
			// Debug.Log(checkPlayer.name);
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.layer == 7)
		{
			checkPlayer = null;
		}
	}
}
