using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing = 5f;

	Vector3 offset;

	void Start()
	{
		offset = Transform.position - target.position;
	}

	void FixedUpdate()
	{
		Vector3 targetCamPos = AvatarTarget.position + offset;
		Transform.position = Vector3.Lerp (Transform.position, targetCamPos, smoothing * Time.deltaTime);
	}
}
