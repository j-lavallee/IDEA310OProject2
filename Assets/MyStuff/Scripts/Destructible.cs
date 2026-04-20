// --------------------------------------
// This script is totally optional. It is an example of how you can use the
// destructible versions of the objects as demonstrated in my tutorial.
// Watch the tutorial over at http://youtube.com/brackeys/.
// --------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

	public GameObject destroyedVersion; // Reference to the shattered version of the object
	public GameObject player;
	public float distance;

	// If the player clicks on the object
	void OnMouseDown ()
	{
		if (distance < 5)
		{
			// Spawn a shattered object
			Instantiate(destroyedVersion, transform.position, transform.rotation);
			// Remove the current object
			Destroy(gameObject);
		}
	}

    private void Update()
    {
		distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
    }

}
