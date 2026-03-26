using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonFadeScene : MonoBehaviour
{
    public Image fadePanel;
    public string sceneName = "Outside";
    public float fadeDuration = 1.5f;

    public void OnButtonClick()
    {
        if (fadePanel != null)
        {
            StartCoroutine(FadeAndLoad());
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    IEnumerator FadeAndLoad()
    {
        Color c = fadePanel.color;
        c.a = 0;
        fadePanel.color = c;

        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            c.a = Mathf.Clamp01(t / fadeDuration);
            fadePanel.color = c;
            yield return null;
        }

        SceneManager.LoadScene(sceneName);
    }
}
