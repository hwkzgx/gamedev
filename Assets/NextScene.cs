using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [Header("Scene Settings")]
    public string nextSceneName; 

    private bool finished = false; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (finished) return;

        if (other.CompareTag("Player"))
        {
            finished = true;

            SceneManager.LoadScene(nextSceneName);
        }
    }
}
