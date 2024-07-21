using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public float sensitivity = 5.0f; // Mouse sensitivity
    public float minY = -80f;          // Minimum Y angle
    public float maxY = 80f;          // Maximum Y angle

    private Vector3 rotation = Vector3.zero;
    private Transform cameraTransform;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

	// Use this for initialization
	void Start () {
		cameraTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Cursor.lockState != CursorLockMode.Locked) return;

		yaw += sensitivity * Input.GetAxis("Mouse X");
		pitch -= sensitivity * Input.GetAxis("Mouse Y");
		pitch = Mathf.Clamp(pitch, minY, maxY);

		rotation = new Vector3(pitch, yaw, 0);
		cameraTransform.eulerAngles = rotation;
	}

	public void LockCursor() {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	public void UnlockCursor() {
	Cursor.lockState = CursorLockMode.None;
	Cursor.visible = true;
	}
}




