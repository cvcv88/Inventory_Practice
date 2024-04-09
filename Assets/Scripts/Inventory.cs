using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventory : MonoBehaviour
{
	[SerializeField] InvenUI invenUI;
	public Dictionary<string, int> items = new Dictionary<string, int>();

	// ������ �߰�
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
			invenUI.PrintExplainText(str + "��(��) �κ��丮�� �߰��߽��ϴ�.");
			invenUI.PrintNameText();
		}
		else
		{
			invenUI.PrintExplainText(str + "��/�� �̹� �κ��丮�� �����մϴ�.");
		}
	}

	// ������ ���
	public void RemoveInven(string str)
	{
		if (FindInven(str))
		{
			Debug.Log(str);
			items.Remove(str);
			PrintInven();
			invenUI.PrintExplainText(str + "��(��) �κ��丮���� �����߽��ϴ�.");
			invenUI.PrintNameText();
		}
	}

	public bool FindInven(string str)
	{
		if (items.ContainsKey(str))
		{
			invenUI.PrintExplainText(str + "��(��) �κ��丮�� �����մϴ�");
			return true;
		}
		invenUI.PrintExplainText("�κ��丮�� �ش� �������� �����ϴ�.");
		return false;
	}

	// �κ��丮 ���� ��� ������ ����
	public void ClearInven()
	{
		items.Clear();
		invenUI.PrintNameText();
		// Debug.Log("�κ��丮�� ������ϴ�.");
		invenUI.PrintExplainText("�κ��丮�� ������ϴ�.");
	}

	// �κ��丮 ���� ��� ������ ���
	public void PrintInven()
	{
		Debug.Log("�κ��丮 ������ ���:");
		foreach (var i in items)
		{
			Debug.Log("- " + i);
		}
	}
}
