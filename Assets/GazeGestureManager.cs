using UnityEngine;
using UnityEngine.VR.WSA.Input;

public class GazeGestureManager : MonoBehaviour
{
	[HideInInspector]
	public static GazeGestureManager Instance { get; private set; }

	public GazeEvents focusedObject = null;
	GestureRecognizer recognizer;

	void Awake()
	{
		Instance = this;
		recognizer = new GestureRecognizer();
		recognizer.TappedEvent += (source, tapCount, ray) =>
		{
			if (focusedObject != null)
				focusedObject.Select();
		};
		recognizer.StartCapturingGestures();
	}
}