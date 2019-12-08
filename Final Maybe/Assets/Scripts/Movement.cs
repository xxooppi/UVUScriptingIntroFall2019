
using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{

	private float speed = 10f, gravity = -9.81f, jumpSpeed = 55f;
	private Vector3 position;
	private int jumpCount;
	private int jumpCountMax = 2;
	private CharacterController controller;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	void Update ()
	{
		position.x = speed * Input.GetAxis("Horizontal");

		if (!controller.isGrounded)
		{
			position.z += gravity;
		}
		
		if (controller.isGrounded)
		{
			jumpCount = 0;
			position.z = 0;
		}

		if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
		{
			jumpCount++;
			position.z = jumpSpeed;
		}

		controller.Move(position * Time.deltaTime);

	}
}
