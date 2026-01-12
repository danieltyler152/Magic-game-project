using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("UIscene");
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