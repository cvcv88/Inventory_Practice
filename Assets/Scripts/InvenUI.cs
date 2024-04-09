using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class InvenUI : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI[] itemText;
	[SerializeField] TextMeshProUGUI explainText;
	[SerializeField] Inventory inven;
	int count = 0;
	int i = 0;

	private void Start()
	{
	}

	private void Update()
	{
		count = inven.items.Count;
	}

	public void PrintNameText()
	{
		//Debug.Log(itemText.Length);
		for(int i = 0; i < itemText.Length; i++)
		{ // 0, 1, 2
			Debug.Log(i);
			Debug.Log(count);
			/*Debug.Log(itemText[i].text);
			Debug.Log(inven.items[i].itemName);*/
			Debug.Log("---");

			if (i <= count)
				itemText[i].text = inven.items.Keys.ToString();
		}
	}

	public void PrintExplainText(string str)
	{
		explainText.text = str;
	}

	[ContextMenu("test")]
	public void Test()
	{
		PrintNameText();
	}
}
