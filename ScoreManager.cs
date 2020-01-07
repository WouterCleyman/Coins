using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    // Use this for initialization
    public static ScoreManager instance;
    public Text text;
    int score;
	void Start () {
		if(instance == null)
        {
            instance = this;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();
    }
}
