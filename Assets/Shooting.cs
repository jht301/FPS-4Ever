using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    public AudioClip r;
    float timer;
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (Input.touchCount > 0) {
            if (Input.GetTouch(0).pressure >= 3&& timer <=0) {
                SoundManager.me.Play(r);
                timer = .1f;

            }
            if (Input.touchCount > 1) {
                if (Input.GetTouch(1).pressure >= 3 && timer <=0) {
                    SoundManager.me.Play(r);
                    timer = .1f;
                }
            }
        }
	}
}
