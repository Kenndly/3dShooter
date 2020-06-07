using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otbeg : MonoBehaviour
{
    public Transform Transform;
    public GameObject GameObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(GameObject.transform.position, gameObject.transform.position) < 3)
        {
            print("123");
            gameObject.transform.position=Vector3.MoveTowards(gameObject.transform.position, Transform.transform.position,2);
            print("12222223");
        }
    }
}
