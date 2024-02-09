using UnityEngine.UI;
using UnityEngine;
using System.Globalization;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    //public int CurrentScore;
    public Text Highscore;
    
    void start ()
    {
        Highscore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
    }
    // Update is called once per frame
    void Update()
    {
        //int number;
        //score.text = number.ToString("0");
        
        score.text = player.position.z.ToString("0");
        //score.text = CurrentScore.ToString();
        /*if (player.position.z > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", player.position.z);
            Highscore.text = player.position.z.ToString("0");
        }*/

    }
}
