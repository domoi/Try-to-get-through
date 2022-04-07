using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private void Start()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y);
    }
    void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) < 1.8f)
        {
            transform.position = new Vector2(transform.position.x,0.3f);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, -1f);
        }
    }
}
