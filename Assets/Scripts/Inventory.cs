using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventory : MonoBehaviour
{
	[SerializeField] InvenUI invenUI;
	public Dictionary<string, int> items = new Dictionary<string, int>();

	// 아이템 추가
	public void AddInven(string str)
	{
		if (!FindInven(str))
		{
			if (items.ContainsKey(str))
			{
				items.Add(str, 1);
			}
			else
			{
				items[str] += 1;
			}
			invenUI.PrintExplainText(str + "을(를) 인벤토리에 추가했습니다.");
			invenUI.PrintNameText();
		}
		else
		{
			invenUI.PrintExplainText(str + "은/는 이미 인벤토리에 존재합니다.");
		}
	}

	// 아이템 사용
	public void RemoveInven(string str)
	{
		if (FindInven(str))
		{
			Debug.Log(str);
			items.Remove(str);
			PrintInven();
			invenUI.PrintExplainText(str + "을(를) 인벤토리에서 제거했습니다.");
			invenUI.PrintNameText();
		}
	}

	public bool FindInven(string str)
	{
		if (items.ContainsKey(str))
		{
			invenUI.PrintExplainText(str + "이(가) 인벤토리에 존재합니다");
			return true;
		}
		invenUI.PrintExplainText("인벤토리에 해당 아이템이 없습니다.");
		return false;
	}

	// 인벤토리 내의 모든 아이템 제거
	public void ClearInven()
	{
		items.Clear();
		invenUI.PrintNameText();
		// Debug.Log("인벤토리를 비웠습니다.");
		invenUI.PrintExplainText("인벤토리를 비웠습니다.");
	}

	// 인벤토리 내의 모든 아이템 출력
	public void PrintInven()
	{
		Debug.Log("인벤토리 아이템 목록:");
		foreach (var i in items)
		{
			Debug.Log("- " + i);
		}
	}
}
