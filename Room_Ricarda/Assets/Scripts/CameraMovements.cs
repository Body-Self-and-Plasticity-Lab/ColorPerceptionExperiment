using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovements : MonoBehaviour {

    public Transform myCamera;
    private Vector3 updatedTransform;

    public float speed;

	// Use this for initialization
	void Start () {
        updatedTransform = new Vector3(0, 0, 0);
        myCamera.position = updatedTransform;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("left")) //when user presses the left arrow key do the following:
        {
           updatedTransform.x = updatedTransform.x - speed; //update the vector to the original vector +- the speed in one axis.
        }

        if (Input.GetKey("right"))
        {
            updatedTransform.x = updatedTransform.x + speed;
        }

        if (Input.GetKey("up"))
        {
            updatedTransform.y = updatedTransform.y + speed;
        }

        if (Input.GetKey("down"))
        {
            updatedTransform.y = updatedTransform.y - speed;
        }

        myCamera.position = updatedTransform;

        if (Input.GetKeyDown("p"))
        {
            Debug.Log("My camera position is now: " + myCamera.position); // prints the camera position
        }
        
    }
}
