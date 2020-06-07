using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void SpawnOnDropped()
    {
        Vector3 playerPos = new Vector3(player.position.x, player.position.y-0.6f, player.position.z + 1.5f);
        Instantiate(item,playerPos,Quaternion.identity);
    }
}
