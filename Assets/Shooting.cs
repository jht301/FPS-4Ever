using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0) {
            if (Input.GetTouch(0).pressure >= 3) {
                Debug.Log("first finger shoot");
            }
            if (Input.touchCount > 1) {
                if (Input.GetTouch(1).pressure >= 3) {
                    Debug.Log("second Finge shoot");
                }
            }
        }
	}
}
