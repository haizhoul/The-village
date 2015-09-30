using UnityEngine;
using System.Collections;

public class navigate : MonoBehaviour
{
	Transform target;               // Reference to the player's position.
	NavMeshAgent nav;               // Reference to the nav mesh agent.
	
	
	void Awake ()
	{
		// Set up the references.
		target = GameObject.FindGameObjectWithTag ("target").transform;

		nav = GetComponent <NavMeshAgent> ();
	}
	
	
	void Update ()
	{

			// ... set the destination of the nav mesh agent to the player.
			nav.SetDestination (target.position);
		//∫Destroy (nav, 3f);
	} 
}