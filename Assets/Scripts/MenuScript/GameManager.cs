using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Text score;
    private void Start()
    {
        score.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void Play()
    {
        SceneManager.LoadScene("Play");
        
    }
}
