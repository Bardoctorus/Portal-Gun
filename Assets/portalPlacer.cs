using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalPlacer : MonoBehaviour {
   
    
    //public Gameobjects for the portals so our player can move them
    //these can be assigned in teh inspector
    public GameObject bluePortal;
    public GameObject orangePortal;
    
    RaycastHit portalGunHit;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
          if(Physics.Raycast(transform.position,Camera.main.transform.forward, out portalGunHit))
            {
                MovePortal(portalGunHit,bluePortal);
            }
             
        }

        if(Input.GetMouseButtonDown(1))
        {
           
            if(Physics.Raycast(transform.position,Camera.main.transform.forward, out portalGunHit))
            {
                MovePortal(portalGunHit,orangePortal);
            }
            
        }
	}


    void MovePortal(RaycastHit hit, GameObject portal)
    {
        portal.transform.position = hit.point;
        portal.transform.rotation = Quaternion.LookRotation(hit.normal);
        Debug.Log("portal rotation   "+portal.transform.rotation);
        Debug.Log("hit normal    " + hit.normal);
        Debug.Log("Quat eul norm hit   "+Quaternion.Euler(hit.normal));

    }


}
