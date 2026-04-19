using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public string scene;
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(scene);
    }
}
