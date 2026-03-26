using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName = "Outside";

    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
