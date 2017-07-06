using UnityEngine;
using UnityEngine.Events;

public class GazeEvents : MonoBehaviour {
	new Camera camera;
	bool gazing;

	public UnityEvent onGaze;
	public UnityEvent onGazeOut;
	public UnityEvent onSelect;

	void Start () {
		camera = Camera.main;
	}
	
	public void Select() {
		onSelect.Invoke();
	}

	void Update () {
		 var headPosition = camera.transform.position;
		var gazeDirection = camera.transform.forward;

		RaycastHit hitInfo;

		if (Physics.Raycast(headPosition, gazeDirection, out hitInfo)) {
			if(hitInfo.transform == transform) {
				if(!gazing) {
					gazing = true;
					GazeGestureManager.Instance.focusedObject = this;
					onGaze.Invoke();
				}
			} else {
				if(gazing) {
					gazing = false;
					if(GazeGestureManager.Instance.focusedObject == this) {
						GazeGestureManager.Instance.focusedObject = null;
					}
					onGazeOut.Invoke();
				}
			}
		}
		else if(gazing) {
			if(gazing) {
				gazing = false;
				if(GazeGestureManager.Instance.focusedObject == this) {
					GazeGestureManager.Instance.focusedObject = null;
				}
				onGazeOut.Invoke();
			}
		}
	}
}
