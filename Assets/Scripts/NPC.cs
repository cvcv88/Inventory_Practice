using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
	// 사과가 필요한 NPC

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
			Debug.Log("NPC가 사과를 받고 기뻐합니다.");
			return true;
		}
		else
		{
			Debug.Log("아이템이 없습니다.");
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
