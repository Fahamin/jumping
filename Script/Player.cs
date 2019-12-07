using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float JumpSpeed ;
    private Rigidbody Rigidbody;
    private bool onGround = true;

    public static Player instance;

	// Use this for initialization
	void Start () {
        instance = this;
        Rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        JumpPlayer();

       

    }

    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            onGround = true;
            JumpPlayer();
        }

       
    }

    void JumpPlayer()
    {
        if (Input.GetKeyDown("space") && onGround == true)
        {
           Rigidbody.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
            onGround = false;
           
        }

        if (Input.touchCount == 1 && onGround==true)
        {
            Rigidbody.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
            onGround = false;
        }
    }

    public void Jump()
    {
        if (onGround == true)
        {
            Rigidbody.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Finish"))
        {
            GameManager.instance.CountPoint += 2;
            GameManager.instance.pointspeed += 2;
           
        }

        if (other.gameObject.CompareTag("Box"))
        {
            // GameManager.instance.life -= 10;
            GameManager.instance.GameOver();
            Destroy(this.gameObject);


        }

    }


}
