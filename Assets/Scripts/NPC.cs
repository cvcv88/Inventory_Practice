using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
	// ����� �ʿ��� NPC

	// [SerializeField] Inventory inven;
	[SerializeField] Inventory inven;
	[SerializeField] Item item;
	[SerializeField] InvenUI invenUI;
	GameObject checkPlayer;

	private void Start()
	{

	}
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.X))
		{
			CheckItem();
		}
	}

	private bool CheckItem()
	{
		if (inven.FindInven(item.name) && checkPlayer != null)
		{
			inven.RemoveInven(item.name);
			Debug.Log("NPC�� ����� �ް� �⻵�մϴ�.");
			return true;
		}
		else
		{
			Debug.Log("�������� �����ϴ�.");
			return false;
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
