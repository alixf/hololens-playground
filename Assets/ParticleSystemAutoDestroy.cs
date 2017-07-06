using UnityEngine;

public class ParticleSystemAutoDestroy : MonoBehaviour 
{
	ParticleSystem ps;

	public void Start() {
		ps = GetComponent<ParticleSystem>();
	}

	public void Update() 
	{
		if(ps && !ps.IsAlive()) {
			Destroy(gameObject);
		}
	}
}