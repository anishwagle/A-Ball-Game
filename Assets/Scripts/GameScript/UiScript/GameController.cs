using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public GameObject pauseMenuUi;
    public GameObject startMenuUi;


    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Play");
        startMenuUi.SetActive(false);
        Time.timeScale = 1f;
    }
    public void StartGame()
    {
        startMenuUi.SetActive(false);
        Time.timeScale = 1f;
    }

}
