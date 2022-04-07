using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTwo : MonoBehaviour
{
    private GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }
    public void StartLevel()
    {
        SceneManager.LoadScene(3);
        gm.lastCheckPoint = new Vector2(0, 0);
    }
}
