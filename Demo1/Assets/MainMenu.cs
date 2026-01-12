using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("UIscene");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("Demo1");
    }
    public void creditsButton()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void controlsButton()
    {
        SceneManager.LoadScene("ControlsScene");
    }

    public void quitButton()
    {
        Application.Quit();
    }
}