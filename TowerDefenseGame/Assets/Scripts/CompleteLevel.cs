using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public SceneFader sceneFader;
    public string menuSceneName = "MainMenu";
    public string nextLevel = "Level02";
    public int levelToUnlock = 2;

    private void OnEnable()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
    }

    public void Continue()
    {
        sceneFader.FadeTo(nextLevel);
    }

    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
    }
}
