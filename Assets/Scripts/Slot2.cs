﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot2 : MonoBehaviour
{
    private Inventory inventory;
    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Spawn>().SpawnOnDropped();
            GameObject.Destroy(child.gameObject);
        }
    }
    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull[1] = false;
        }
        if (Input.GetKey(KeyCode.F2))
        {
            DropItem();
        }
    }
}
