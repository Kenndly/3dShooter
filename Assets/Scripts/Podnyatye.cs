using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podnyatye : MonoBehaviour
{
    private Inventory inventory;
    public GameObject ItemButton;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if(other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++) 
            {
                if (inventory.isFull[i]==false)
                {   
                    Instantiate(ItemButton,inventory.slots[i].transform);
                    Destroy(gameObject);                    
                    inventory.isFull[i] = true;   
                    break;
                }
            }
        }       
    }
}
