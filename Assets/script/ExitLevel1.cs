using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel1 : MonoBehaviour
{
    [SerializeField] private int nextLevelIndex;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ChangeScene();
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene(nextLevelIndex);
    }
}
