using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    private int score = 0;
    public Text scoreText = null;
	// Use this for initialization
	void Start () {
        ScoreUp(0);
	
	}
    public void ScoreUp(int sc)
    {
        score += sc;
        scoreText.text = "SCORE : " + score.ToString();
    }

    public void Replay()
    {
        Application.LoadLevel("GameScene");
    }
	
    //// Update is called once per frame
    //void Update () {
	
    //}
}
