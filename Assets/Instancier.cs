using UnityEngine;

public class Instancier : MonoBehaviour {

	public GameObject objectToInstantiate;
	public Vector3 minPosition;
	public Vector3 maxPosition;

	public void Use() {
		var instance = Instantiate(objectToInstantiate);
		instance.transform.position = new Vector3(
			Mathf.Lerp(minPosition.x, maxPosition.x, Random.value),
			Mathf.Lerp(minPosition.y, maxPosition.y, Random.value),
			Mathf.Lerp(minPosition.z, maxPosition.z, Random.value)
		);
	}
}
