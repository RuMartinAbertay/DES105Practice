using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenuMain : MonoBehaviour
{
    public void PlayButtonPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitButtonPress ()
    {
        Application.Quit();
    }
}
