using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class vehicle : MonoBehaviour
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

	public bool isGamepad;

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
		anchor = GameObject.Find("Anchor");
    }

	Rigidbody r;

	GameObject anchor;

    void Update()
    {
		float horizontalInput = Input.GetAxis("Horizontal");
		float triggerInput = Input.GetAxis("Accelerate");

		r.transform.Rotate(0,120*playerControls.Driving.Steer.ReadValue<float>()*Time.deltaTime,0);
		anchor.transform.Rotate(0,-120*playerControls.Driving.Steer.ReadValue<float>()*Time.deltaTime,0);

		r.AddForce(1000 * (playerControls.Driving.Accelerate.ReadValue<float>() - 0.8f*playerControls.Driving.Decelerate.ReadValue<float>()) * transform.forward * Time.deltaTime);

		if (Input.GetButton("Respawn") || transform.position.y < -2)
		{
			r.velocity = Vector3.zero;
			transform.SetPositionAndRotation(new Vector3(0,3,0), Quaternion.Euler(0, -90, 0));
			anchor.transform.rotation = new Quaternion(0,0,0,0);
		}
		
		if (isGamepad)
        {
			if (playerControls.Driving.Aim.ReadValue<Vector2>().x != 0 && playerControls.Driving.Aim.ReadValue<Vector2>().y != 0)
			{
			    Vector3 direction = Vector3.right * playerControls.Driving.Aim.ReadValue<Vector2>().x + Vector3.forward * playerControls.Driving.Aim.ReadValue<Vector2>().y;
				anchor.transform.rotation = Quaternion.RotateTowards(anchor.transform.rotation, Quaternion.LookRotation(direction), 1500 * Time.deltaTime);
			}
        }
	}

	public void OnDeviceChange(PlayerInput pi)
	{
		isGamepad = pi.currentControlScheme.Equals("Gamepad") ? true : false;
	}
}
