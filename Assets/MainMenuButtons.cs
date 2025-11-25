using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitPressed()
    {
        //Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
