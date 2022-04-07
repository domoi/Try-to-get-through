using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {           
        if(other.CompareTag("Player"))
        {
            gm.lastCheckPoint = transform.position;
        }   
    }
}