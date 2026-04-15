using UnityEngine;

public class PunchHitbox : MonoBehaviour
{
    public GameObject ragdoll;
    public float force;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ohko"))
        {
            Debug.Log("hit");
            Destroy(other.gameObject);
            var rg = Instantiate(ragdoll, other.transform.position, other.transform.rotation);

            foreach (Rigidbody bone in rg.GetComponentsInChildren<Rigidbody>()){
                bone.AddForce(transform.forward * force, ForceMode.Impulse);
            }
        }
    }
}
