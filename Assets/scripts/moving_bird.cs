using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_bird : MonoBehaviour {

	private Vector3 posA;

	private Vector3 posB;

	private Vector3 nextPos;

	public bool MovingRight = true;

	[SerializeField]
	private float speed;

	[SerializeField]
	private Transform childTransform;

	[SerializeField]
	private Transform transformB;

	// Use this for initialization
	void Start () {

		posA = childTransform.localPosition;
		posB = transformB.localPosition;
		nextPos = posB;

	}

	// Update is called once per frame
	void Update () {

		Move ();
	}
	public void Move(){

		childTransform.localPosition = Vector3.MoveTowards (childTransform.localPosition, nextPos, speed * Time.deltaTime);
		if (Vector3.Distance (childTransform.localPosition, nextPos) <= 0.1) {

			ChangeDestination ();
			if (MovingRight == true) {
				transform.eulerAngles = new Vector3 (0, -180, 0);
				MovingRight = false;

			} else {
				transform.eulerAngles = new Vector3 (0,0,0);
				MovingRight = true;
		}

	}
	}

	private void ChangeDestination (){

		nextPos = nextPos != posA ? posA : posB;
	}

}
