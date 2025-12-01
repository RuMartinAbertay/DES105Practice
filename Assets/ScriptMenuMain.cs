using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenuMain : MonoBehaviour
{
    // = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // ScriptMenuMain:
    // Any menu buttons with functions not handled by the objects themselves are handled here.
    // = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

    // When the play button is pressed, loads the next scene in the index ("main")
    public void PlayButtonPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // When the quit button is pressed, exits the application
    public void QuitButtonPress ()
    {
        Application.Quit();
        //AGH
    }
}
