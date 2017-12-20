using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour {

    Rigidbody r;
    public float speedNow;
        
   // Use this for initialization
	void Start () {
        r = GetComponent<Rigidbody>();
       // r.useGravity = false;
  
        //StartCoroutine(PauseAtStart());
        r.AddTorque(.8f, .7f, .6f);
    }
	
	// Update is called once per frame
	void Update () {
        speedNow = r.velocity.magnitude;
        //Debug.Log(speedNow);
	}

    IEnumerator PauseAtStart()
    {
        yield return new WaitForSeconds(5);
        r.useGravity = true;
    }
}
