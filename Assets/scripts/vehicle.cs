using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class vehicle : MonoBehaviour
{
	private PlayerInput playerInput;
	private CharacterController controller;
	private PlayerControls playerControls;

	public GameObject cam;
	public bool isGamepad;
	public Rigidbody vehicleRigidBody;
	public GameObject anchor;


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


    void Update()
    {
		rotate();
		accelerate();
		aim();

		if (Input.GetButton("Respawn") || transform.position.y < -2)
		{
			vehicleRigidBody.velocity = Vector3.zero;
			transform.SetPositionAndRotation(new Vector3(0,3,-20), Quaternion.Euler(0, -90, 0));
			anchor.transform.rotation = new Quaternion(0,0,0,0);
		}
	}

	public void OnSteer(InputValue value)
    {
		Debug.Log(value);
		//vehicleRigidBody.transform.Rotate(0, 120 * playerControls.Driving.Steer.ReadValue<float>() * Time.deltaTime, 0);
		//anchor.transform.Rotate(0, -120 * playerControls.Driving.Steer.ReadValue<float>() * Time.deltaTime, 0);
	}

	private void rotate()
    {
		vehicleRigidBody.transform.Rotate(0, 120 * playerControls.Driving.Steer.ReadValue<float>() * Time.deltaTime, 0);
		anchor.transform.Rotate(0, -120 * playerControls.Driving.Steer.ReadValue<float>() * Time.deltaTime, 0);
	}

	private void accelerate()
    {
		vehicleRigidBody.AddForce(1000 * (playerControls.Driving.Accelerate.ReadValue<float>() - 0.8f * playerControls.Driving.Decelerate.ReadValue<float>()) * transform.forward * Time.deltaTime);
	}

	private void aim()
    {
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
