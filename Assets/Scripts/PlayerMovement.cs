using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	//
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	// We marked this as "Fixed"Update because we
	// are using it to mess with physics.
	void Update () {
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("a") || Input.GetKey("left")) {
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("d") || Input.GetKey("right")) {
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f){
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
