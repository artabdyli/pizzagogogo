using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

/// <summary>
/// For user multiplatform control.
/// </summary>
[RequireComponent (typeof (CarController))]
public class UserControl :MonoBehaviour
{

	CarController ControlledCar;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
    private PlayerInput playerInput;
#endif
    private StarterAssetsInputs input;
    public float Horizontal { get; private set; }
	public float Vertical { get; private set; }
	public bool Brake { get; private set; }

	public static MobileControlUI CurrentUIControl { get; set; }

	private void Awake ()
	{
		ControlledCar = GetComponent<CarController> ();
		CurrentUIControl = FindObjectOfType<MobileControlUI> ();
        playerInput = GetComponent<PlayerInput>();
        input = GetComponent<StarterAssetsInputs>();
    }

	void Update ()
	{
		if (CurrentUIControl != null && CurrentUIControl.ControlInUse)
		{
			//Mobile control.
			Horizontal = CurrentUIControl.GetHorizontalAxis;
			Vertical = CurrentUIControl.GetVerticalAxis;
		}
		else
		{
			//Standart input control (Keyboard or gamepad).
			Horizontal = input.move.x;
			Vertical = input.move.y;
			//temporär
			Brake = false;
		}

		//Apply control for controlled car.
		ControlledCar.UpdateControls (Horizontal, Vertical, Brake);
	}
}
