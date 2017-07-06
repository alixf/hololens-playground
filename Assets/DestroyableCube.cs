using UnityEngine;

public class DestroyableCube : MonoBehaviour {

	public GameObject particles;
	
	public void Destroy() {
		var particlesInstance = Instantiate(particles);
		particlesInstance.transform.position = transform.position;
		particlesInstance.transform.rotation = transform.rotation;
		particlesInstance.transform.localScale = transform.localScale;
		Destroy(gameObject, 0.1f);
	}
}
