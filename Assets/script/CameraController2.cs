using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    [SerializeField] private Transform player;

    private Vector3 pos;

    private void Start()
    {
        if (!player)
        {
            player = FindObjectOfType<PlayerController>().transform;

        }
    }
    private void Update()
    {
        pos = player.position;

        pos.z = -10f;

        transform.position = Vector3.Lerp(transform.position, pos, 10);

    }
}

