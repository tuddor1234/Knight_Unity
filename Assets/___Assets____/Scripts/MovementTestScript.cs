using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class MovementTestScript : MonoBehaviour {

    public float force = 5;
    public Text txt;

    Rigidbody2D rb;
   
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();

	}
	
	void FixedUpdate ()
    {
        Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical"));
        print(moveVec);
        rb.AddForce(moveVec * force);
        txt.text = moveVec.ToString();
    }
}
