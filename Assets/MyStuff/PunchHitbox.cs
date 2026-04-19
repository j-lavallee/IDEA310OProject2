using UnityEngine;

public class PunchHitbox : MonoBehaviour
{
    public GameObject ragdoll;
    public float force;
    public healthBar healthBar;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ohko"))
        {
            healthBar.health += 10;
            Destroy(other.gameObject);
            var rg = Instantiate(ragdoll, other.transform.position, other.transform.rotation);

            foreach (Rigidbody bone in rg.GetComponentsInChildren<Rigidbody>()){
                bone.AddForce(gameObject.transform.forward * force, ForceMode.Impulse);
            }
        }
    }
}
