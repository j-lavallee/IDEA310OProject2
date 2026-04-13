using UnityEngine;

public class PunchHitbox : MonoBehaviour
{
    public GameObject ragdoll;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ohko"))
        {
            Debug.Log("hit");
            Instantiate(ragdoll, transform.position, transform.rotation);
            Destroy(other.gameObject);
            ragdoll.GetComponentInChildren<Rigidbody>().AddForce(transform.forward * 10);
        }
    }
}
