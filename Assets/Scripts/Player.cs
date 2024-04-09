using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] Inventory inven;
	GameObject nearObject;
	Rigidbody rigid;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
	}
	private void Update()
	{
		Move();
		if (Input.GetKeyDown(KeyCode.Space) && nearObject != null)
		{
			AddInven();
		}
		if (Input.GetKeyDown(KeyCode.Z))
		{
			PrintInven();
		}
	}

	private void Move()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 moveDir = new Vector3(moveHorizontal, 0f, moveVertical);

		rigid.velocity = 10f * moveDir;
	}

	private void AddInven()
	{
		inven.AddInven(nearObject.name);
	}

	private void PrintInven()
	{
		inven.PrintInven();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.layer == 6) // Item layer
		{
			nearObject = collision.gameObject;
		}
	}
	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.layer == 6) // Item layer
		{
			nearObject = null;
		}
	}
}
