using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    public Button level2B;
    int levelComplete;

    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        level2B.interactable = false;

        switch (levelComplete)
        {
            case 1:
                level2B.interactable = true;
                break;
        }
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }
}
