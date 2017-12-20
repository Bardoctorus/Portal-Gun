using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class portalTest : MonoBehaviour
{
    //public Gameobjects the Portals need to know about
    //these can be assigned in the inspector
    public GameObject cube; 
    public GameObject otherPortal;
    void Start()
    {
    }

     void Update()
    {

        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "testCube")
        {
            float p = other.GetComponent<Rigidbody>().velocity.magnitude;
           // Debug.Log("speed on impact =" + p);
            Vector3 newDir = otherPortal.transform.forward * p;
            other.transform.position = otherPortal.transform.position + (otherPortal.transform.forward * 5);
            other.GetComponent<Rigidbody>().velocity = newDir;          
         }

        if (other.gameObject.tag == "Player")
        {
            float p = other.GetComponent<CharacterController>().velocity.magnitude;
            //Debug.Log("speed on impact =" + p);
            Vector3 newDir = otherPortal.transform.forward * p;
            other.GetComponent<FirstPersonController>().enabled = false;
            other.transform.position = otherPortal.transform.position +  (otherPortal.transform.forward * 5);
            other.transform.rotation = Quaternion.LookRotation(newDir,Vector3.up);
            other.GetComponent<FirstPersonController>().enabled = true;

            var rb = other.GetComponent<Rigidbody>();
            var v = Vector3.Reflect(rb.velocity, transform.forward);

            
            
            rb.velocity = v;
           
        }
    }

 
}
