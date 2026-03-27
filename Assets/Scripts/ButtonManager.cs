using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    
    
    public void OnPlay()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnQuit()
    {
        Application.Quit();
    }
    public void OnRestart()
    {
        SceneManager.LoadScene("Game");
    }
}
