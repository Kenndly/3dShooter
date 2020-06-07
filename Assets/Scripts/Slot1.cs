using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot1 : MonoBehaviour
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
            inventory.isFull[0] = false;
        }
        if (Input.GetKey(KeyCode.F1))
        {
            DropItem();
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            foreach (Transform child in transform)
            {
                child.gameObject.transform.position = new Vector3(1, 1, 1);
            }
        }
    }
}
