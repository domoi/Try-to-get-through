using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button level2b;
    public Button level3b;
    int levelComplete;

    private void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        level2b.interactable = false;
        level3b.interactable = false;

        switch (levelComplete)
        {
            case 2:
                level2b.interactable = true;
                break;
            case 3:
                level2b.interactable = true;
                level3b.interactable = true;
                break;
        }
    }
    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void Reset()
    {
        level2b.interactable = false;
        level3b.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}
