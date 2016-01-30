using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    bool isMoving = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Cardboard.SDK.Triggered == true)
        {
            isMoving = !isMoving;
        }

        if (isMoving)
        {

        }
	}

    private void SDK_OnTrigger()
    {
        throw new System.NotImplementedException();
    }
}
