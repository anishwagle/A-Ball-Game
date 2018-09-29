using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {
    public Transform player;
    public Text score;
    public Text highscore;
    private int number;
    private float mytime=0f;
    private float nexttime = 0f;


    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
        Time.timeScale = 0f;
    }
    // Update is called once per frame
    void Update () {
        number = (int)(player.position.z / 3);


        score.text = (number).ToString();
        if (number > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highscore.text = number.ToString();
        }


    }
}
