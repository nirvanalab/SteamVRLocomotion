using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControllerInput : MonoBehaviour {

    public SteamVR_TrackedObject trackedObj;
    public SteamVR_Controller.Device device;
	// Use this for initialization
	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();

	}
	
	// Update is called once per frame
	void Update () {
        device = SteamVR_Controller.Input((int)trackedObj.index);
        Debug.Log(device);
        
		if(device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        { //returns true as long as thhe button is pressed down
            print("Controller trigger down");
        }

        if(device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            //returs true for the frame where the button was released
            print("Controller trigger up");
        }
	}
}
