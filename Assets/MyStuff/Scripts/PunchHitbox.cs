using UnityEngine;

public class PunchHitbox : MonoBehaviour
{
    public GameObject ragdoll;
    public GameObject ragdollDoor;
    public float force;
    public healthBar healthBar;
    public enemyCounter enemyCounter;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ohko"))
        {
            healthBar.health += 10;
            enemyCounter.addOne();
            Destroy(other.gameObject);
            var rg = Instantiate(ragdoll, other.transform.position, other.transform.rotation);

            foreach (Rigidbody bone in rg.GetComponentsInChildren<Rigidbody>())
            {
                bone.AddForce(gameObject.transform.forward * force, ForceMode.Impulse);
            }
        }
        
        else if (other.gameObject.CompareTag("door"))
        {
            Destroy(other.gameObject);
            var rgd = Instantiate(ragdollDoor, other.transform.position, other.transform.rotation);

            foreach (Rigidbody bone in rgd.GetComponentsInChildren<Rigidbody>())
            {
                bone.AddForce(gameObject.transform.forward * force, ForceMode.Impulse);
            }
        }
    }
}
