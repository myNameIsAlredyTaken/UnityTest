using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseCanvas : MonoBehaviour {

	public Canvas canvasToClose;
	public Button closeButton;
	public CameraControl cameraControl;
	
	public void Close() {
		if (canvasToClose != null) {
			canvasToClose.enabled = false;
		}
			cameraControl.enabled = true;
			cameraControl.LockCursor();
	}

	// Use this for initialization
	void Start () {
		if (closeButton != null) {
			closeButton.onClick.AddListener(Close);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
