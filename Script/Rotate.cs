using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float speed = 5f;
    public static Rotate instance;

    // Use this for initialization
    void Start () {

        instance = this;

	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, 0, speed);

    }
}
