using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    private Text scoreText;

    private GameObject[] aliens;

    private int max;
    private int score;

    void Start ()
    {
        scoreText = GetComponent<Text>();

        aliens = GameObject.FindGameObjectsWithTag("Alien");

        max = aliens.Length;
    }
	
	void Update ()
    {
        aliens = GameObject.FindGameObjectsWithTag("Alien");
        score = aliens.Length;

        scoreText.text = score + "/" + max;
	}
}
