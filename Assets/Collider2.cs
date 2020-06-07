using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.tag == "Ball")
        {
            print("Ura");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
