using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnitySampleAssets.Cameras;
using UnitySampleAssets.CrossPlatformInput;

//TODO wychodzenie z pojazdu w miejscu gdzie mamy wolna przestrzen
//TODO wchodzenie tylko do jednego pojazdu, gdy gracz jest w kilku triggerach
//TODO umożliwienie rozpoczęcia gry w pojeździe

public class VehicleEntrenceController : MonoBehaviour {
	[SerializeField]
	private List<Behaviour> componentsDisabledWithoutDriver = new List<Behaviour>();

	private GameObject driver;
	
	private VehicleState state = VehicleState.Empty;

	void Awake(){
		foreach(Behaviour componentToDisable in componentsDisabledWithoutDriver)
		{
			componentToDisable.enabled = false;
		}
	}

	void OnTriggerStay(Collider other) {
		if(other.tag == "Player" && CrossPlatformInputManager.GetButtonDown("Use"))
		{
			EnterVehicle(other.gameObject);
		}
	}
	
	void Update(){
		switch(state)
		{
			case VehicleState.JustEntered:
				state = VehicleState.Drived;
				break;
			case VehicleState.Drived:
				if(CrossPlatformInputManager.GetButtonDown("Use"))
				{
					ExitVehicle();
				}
				break;
		}
	}
	
	void EnterVehicle(GameObject newDriver){
		state = VehicleState.JustEntered;
		driver = newDriver;
		driver.SetActive(false);
		driver.transform.parent = transform;
		PivotBasedCameraRig.Instance.SetTarget(transform);
//		PivotBasedCameraRig.Instance.SetUpdateType(AbstractTargetFollower.UpdateType.FixedUpdate);
		foreach(Behaviour componentToDisable in componentsDisabledWithoutDriver)
		{
			componentToDisable.enabled = true;
		}
	}
	
	void ExitVehicle(){
		state = VehicleState.Empty;
		driver.SetActive(true);
		driver.transform.parent = null;
		PivotBasedCameraRig.Instance.SetTarget(driver.transform);
//		PivotBasedCameraRig.Instance.SetUpdateType(AbstractTargetFollower.UpdateType.LateUpdate);
		foreach(Behaviour componentToDisable in componentsDisabledWithoutDriver)
		{
			componentToDisable.enabled = false;
		}
		driver = null;
	}
	
	
	public enum VehicleState{
		Empty, JustEntered, Drived
	}
}
