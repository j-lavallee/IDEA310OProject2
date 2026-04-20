using Unity.VisualScripting;
using UnityEngine;

public class enemyCounter : MonoBehaviour
{
    [SerializeField] private int count = 0;
    [SerializeField] private int specifiedCount;
    public GameObject door;
    public GameObject doorIcon;

    // Update is called once per frame
    void Update()
    {
        if (count == specifiedCount)
        {
            door.layer = LayerMask.NameToLayer("Interactable");
            //door.GetComponent<Interactable>().enabled = true;
            doorIcon.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void addOne()
    {
        count++;
    }
}
