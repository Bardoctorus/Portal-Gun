using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalTest : MonoBehaviour
{

    public GameObject cube;
    public GameObject otherPortal;
    Quaternion q;
    void Start()
    {
        q.eulerAngles = new Vector3(0, 180, 0);
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
            other.transform.position = otherPortal.transform.position;
            other.GetComponent<Rigidbody>().velocity = newDir;          
         }

        if (other.gameObject.tag == "Player")
        {
            float p = other.GetComponent<CharacterController>().velocity.magnitude;
            Debug.Log("speed on impact =" + p);
            Vector3 newDir = otherPortal.transform.forward * p;
            other.transform.position = otherPortal.transform.position +  (otherPortal.transform.forward * 5);
            
          
            other.GetComponent<Rigidbody>().velocity = newDir *100;
        }
    }
}
