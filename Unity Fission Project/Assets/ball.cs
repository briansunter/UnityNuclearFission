using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
public GameObject bariumPrefab;
	public GameObject uraniumPrefab;
	public GameObject kryptonPrefab;
	public GameObject neutronPrefab;
	public int uraniumDestroyed;
	// Use this for initialization
	void Start () {
	//	rigidbody.AddExplosionForce(
	//		20,new Vector2(1,4,3),10);
	uraniumDestroyed = GameObject.FindGameObjectsWithTag("Uranium").Length;
	rigidbody.AddRelativeForce(Random.Range(-1,1),Random.Range(-1,1),Random.Range(-1,1),ForceMode.Impulse);
	}
	

	// Update is called once per frame
	void Update () {
		uraniumDestroyed = GameObject.FindGameObjectsWithTag("Uranium").Length;
		if(uraniumDestroyed == 0)
		{
			Application.Quit();
			Debug.Log("ALL URANIUM GONE!!!");
		}
	
	}

void OnCollisionEnter(Collision other) {
	
Debug.Log (tag+ " Hit  "+ other.gameObject.tag);
			rigidbody.AddRelativeForce(Random.Range(-1,1),Random.Range(-1,1),Random.Range(-1,1),ForceMode.Impulse);
		if(tag=="Neutron"&&other.gameObject.tag=="Uranium"){
			Debug.Log("!!!!!!!Nuetron hit uranium");
				Instantiate(bariumPrefab,other.rigidbody.position,other.rigidbody.rotation);
				Instantiate(bariumPrefab,other.rigidbody.position,other.rigidbody.rotation);
				Instantiate(neutronPrefab,other.rigidbody.position,other.rigidbody.rotation);
				Destroy(other.gameObject);
				
				

		}
	}
	

}

