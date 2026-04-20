using UnityEngine;

public class setNewCounter : MonoBehaviour
{
    public PunchHitbox hitbox;
    public enemyCounter newCounter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hitbox.enemyCounter = newCounter;
        }
    }
}
