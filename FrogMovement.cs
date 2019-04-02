using UnityEngine;

public class FrogMovement : MonoBehaviour
{

	public CharacterController2D controller;
	public Animator animator; //to reference animator


	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	private bool jumpFlag = false;
	public float runSpeed = 60f;
	public Rigidbody2D rb;
	internal static RigidbodyConstraints2D constraints;

	void Update()
	{
		horizontalMove = Input.GetAxisRaw("Horizontal_P2") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (jumpFlag)
		{
			animator.SetBool("IsJumping", true);
			jumpFlag = false;
		}

		if (Input.GetButtonDown("Jump_P2"))
		{
			jump = true;

			//tell animator yes we are jumping
			animator.SetBool("IsJumping", true);

		}

		if (Input.GetButtonDown("Crouch_P2"))
		{
			crouch = true;
		}
		else if (Input.GetButtonUp("Crouch_P2"))
		{
			crouch = false;
		}
	}

	void FixedUpdate()
	{
		//move character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);

		if (jump)
		{
			jumpFlag = true;
			jump = false;
		}
	}

	//----------------for movementcontroller----------------
	public void OnLanding()
	{
		animator.SetBool("IsJumping", false);
	}

	public void OnCrouching(bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}
}
