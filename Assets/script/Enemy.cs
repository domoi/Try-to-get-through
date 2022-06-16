using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float up;
    public float down;


    //private void Start()
    //{
    //    transform.position = new Vector2(transform.position.x, transform.position.y);
    //}
    void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) < 2.2f)
        {
            transform.position = new Vector2(transform.position.x, up);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, down);
        }
    }

}
