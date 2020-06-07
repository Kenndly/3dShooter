using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{

    public Animator anim;
    public GameObject ball;
    int point = 0;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {   Debug.Log("123123");
            anim.SetTrigger("Yes");
            point++;
            print(point);
            
        }
    }

    void Update()
    {

    }
}
