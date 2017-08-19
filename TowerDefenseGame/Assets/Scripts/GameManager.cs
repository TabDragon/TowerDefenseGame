using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOver = false;
    public GameObject gameOverUI;
    public SceneFader sceneFader;
    public GameObject completeLevelUI;

    // Use this for initialization
    private void Start()
    {
        // Setup the GameIsOver bool after a scene change, and so on
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update ()
    {
        if (GameIsOver)
            return;

		if(PlayerStats.lives <= 0)
        {
            EndGame();
        }
	}

    private void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        Debug.Log("Level Won!");
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }
}
