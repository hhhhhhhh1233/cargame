using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
	private PlayerInput playerInput;
	private CharacterController controller;
	private PlayerControls playerControls;

	private void Awake()
	{
		playerInput = GetComponent<PlayerInput>();
		controller = GetComponent<CharacterController>();
		playerControls = new PlayerControls();
	}

	private void OnEnable()
	{
		playerControls.Enable();
	}

	private void OnDisable()
	{
		playerControls.Disable();
	}

    void Start()
    {
		r = GetComponent<Rigidbody>();
    }

	Rigidbody r;

    void Update()
    {
		float horizontalInput = Input.GetAxis("Horizontal");
		float triggerInput = Input.GetAxis("Accelerate");

		transform.Rotate(0,120*playerControls.Driving.Steer.ReadValue<float>()*Time.deltaTime,0);

		r.AddForce(1000 * (playerControls.Driving.Accelerate.ReadValue<float>() - 0.8f*playerControls.Driving.Decelerate.ReadValue<float>()) * transform.forward * Time.deltaTime);

		if (Input.GetButton("Respawn"))
		{
			transform.SetPositionAndRotation(new Vector3(0,3,0), Quaternion.Euler(0, 0, 0));
		}
	}
}
