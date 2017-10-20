using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapControl : MonoBehaviour,IMiniMap {

    Vector3 myPos;
    public Transform myPlayer;
    
    Camera ourCamera;

    float heightOfCamera = 5.0f;
  

    public void Over(Vector3 focusOfCamera)
    {
        transform.position = focusOfCamera + heightOfCamera * Vector3.up;
    }

    void Start () {
        ourCamera = GetComponent<Camera>();
	}
	
	void Update () {
        transform.position = myPlayer.position + myPos;
	}
}
