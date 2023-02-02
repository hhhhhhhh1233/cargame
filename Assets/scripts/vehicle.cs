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
	public GameObject projectilePrefab;
	public GameObject obstaclePrefab;
	
	private float steerInput = 0;
	private float accelerateInput = 0;
	private float decelerateInput = 0;
	private Vector2 aimInput = Vector2.zero;

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
	}

	public void OnSteer(InputAction.CallbackContext context)
    {
		steerInput = context.ReadValue<float>();
	}

	public void OnAim(InputAction.CallbackContext context)
	{
		aimInput = context.ReadValue<Vector2>();
	}

	public void OnAccelerate(InputAction.CallbackContext context)
	{
		accelerateInput = context.ReadValue<float>();
	}

	public void OnDecelerate(InputAction.CallbackContext context)
	{
		decelerateInput = context.ReadValue<float>();
	}

	public void OnShoot(InputAction.CallbackContext context)
    {
		if (context.ReadValue<float>() == 1)
        {
			Instantiate(projectilePrefab, transform.position + anchor.transform.forward * 2, anchor.transform.rotation);
        }
    }

	public void OnUseItem(InputAction.CallbackContext context)
    {
		if (context.ReadValue<float>() == 0)
        {
			Instantiate(obstaclePrefab, transform.position + anchor.transform.forward * 2, anchor.transform.rotation);
        }
    }

	private void rotate()
    {
		vehicleRigidBody.transform.Rotate(0, 120 * steerInput * Time.deltaTime, 0);
		anchor.transform.Rotate(0, -120 * steerInput * Time.deltaTime, 0);
	}

	private void accelerate()
    {
		vehicleRigidBody.AddForce(1000 * (accelerateInput - 0.8f * decelerateInput) * transform.forward * Time.deltaTime);
	}

	private void aim()
    {
		if (isGamepad)
		{
			if (aimInput.x != 0 && aimInput.y != 0)
			{
				Vector3 direction = Vector3.right * aimInput.x + Vector3.forward * aimInput.y;
				anchor.transform.rotation = Quaternion.RotateTowards(anchor.transform.rotation, Quaternion.LookRotation(direction), 1500 * Time.deltaTime);
			}
		}
		else
		{
			Vector3 direction = Vector3.right * aimInput.x + Vector3.forward * aimInput.y;
			if (direction != Vector3.zero)
			{
				anchor.transform.rotation = Quaternion.RotateTowards(anchor.transform.rotation, Quaternion.LookRotation(direction), 1500 * Time.deltaTime);
			}
		}
	}

	public void OnDeviceChange(PlayerInput pi)
	{
		isGamepad = pi.currentControlScheme.Equals("Gamepad") ? true : false;
	}

	public void OnRespawn(InputAction.CallbackContext context)
    {
		if (context.ReadValue<float>() == 1)
        {
			vehicleRigidBody.velocity = Vector3.zero;
			transform.SetPositionAndRotation(new Vector3(0, 3, -20), Quaternion.Euler(0, -90, 0));
			anchor.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
	}

	public void OnQuitGame()
	{
		Application.Quit();
	}
}
