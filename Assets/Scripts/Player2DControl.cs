using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]

public class Player2DControl : MonoBehaviour
{
	public float speed = 150;

	public float addForce = 7;

	public KeyCode leftButton = KeyCode.A;

	public KeyCode rightButton = KeyCode.D;

	public KeyCode addForceButton = KeyCode.Space;

	public bool isFacingRight = true;

	private Vector3 direction;

	private float horizontal;

	private Rigidbody2D body;

	private bool jump;

	void Start()
	{
		body = GetComponent<Rigidbody2D>();
	}

	void OnCollisionStay2D(Collision2D coll)
	{
		if (coll.transform.tag == "Ground")
		{
			body.drag = 10;
			jump = true;
		}
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.transform.tag == "Ground")
		{
			body.drag = 0;
			jump = false;
		}
	}

	void FixedUpdate()
	{
		body.AddForce(direction * body.mass * speed);

		if (Mathf.Abs(body.velocity.x) > speed / 100f)
		{
			body.velocity = new Vector2(Mathf.Sign(body.velocity.x) * speed / 100f, body.velocity.y);
		}
		
		if (Input.GetKey(addForceButton) && jump)
		{
			body.velocity = new Vector2(0, addForce);
		}
	}

	void Flip()
	{
		isFacingRight = !isFacingRight;

		Vector3 theScale = transform.localScale;

		theScale.x *= -1;

		transform.localScale = theScale;
	}

	void Update()
	{
		if (Input.GetKey(leftButton)) horizontal = -1;
		else if (Input.GetKey(rightButton)) horizontal = 1; else horizontal = 0;

		direction = new Vector2(horizontal, 0);

		if (horizontal > 0 && !isFacingRight) Flip(); else if (horizontal < 0 && isFacingRight) Flip();
	}
}