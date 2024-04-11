using TMPro;
using UnityEngine;

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
		
	}

	public void PrintNameText()
	{
		//Debug.Log(itemText.Length);
		/*for (int i = 0; i < itemText.Length; i++)
		{ // 0, 1, 2
			Debug.Log(i);
			Debug.Log(count);
			*//*Debug.Log(itemText[i].text);
			Debug.Log(inven.items[i].itemName);*//*
			Debug.Log("---");

			if (i <= count)
				itemText[i].text = inven.items.Keys.ToString();
		}*/
		count = inven.items.Count;
		i = 0;
		foreach (string str in inven.items)
		{
			if (count == 0)
				break;
			itemText[i].text = str;
			i++;
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
