using UnityEngine;

public class GamePause : MonoBehaviour
{
    void Start()
    {
        PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
