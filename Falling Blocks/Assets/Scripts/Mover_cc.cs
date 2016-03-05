using UnityEngine;
using System.Collections;

public class Mover_cc : MonoBehaviour {

	public float speed;
	public float rotateSpeed = 3.0F;
	public CharacterController controller;


	void Start(){
		controller = GetComponent<CharacterController> ();
	}

	void Update(){
		transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
		Vector3 forward = transform.TransformDirection(Vector3.forward);
		float curSpeed = speed * Input.GetAxis("Vertical");
		controller.SimpleMove(forward * curSpeed);
	}

	void onTriggerEnter(Collider other){
	}
}
