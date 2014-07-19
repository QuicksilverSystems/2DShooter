using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
	
	public float characterSpeed = 1f;
	public string horizontalAxisName = "Horizontal";
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += transform.right*Input.GetAxis(horizontalAxisName)*characterSpeed*Time.deltaTime;
		
	}
}
