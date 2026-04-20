using UnityEngine;

public class playPunchSound : MonoBehaviour
{
    public AudioSource source;

    public void playSound()
    {
        source.Play();
    }
}
