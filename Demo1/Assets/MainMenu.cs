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
        }
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("Demo1");
    }
    public void settingsButton()
    {

    }
    public void creditsButton()
    {
        SceneManager.LoadScene("CreditScene");
    }
    public void quitButton()
    {
        Application.Quit();
    }
}