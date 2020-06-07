using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    PlayerMove PlayerMove;
    // Start is called before the first frame update
    public Rigidbody rigidbody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.F5))
        {
            gameObject.SetActive(false);
        }
       // rigidbody.constraints = RigidbodyConstraints.FreezePosition;
        //PlayerMove.isGrounded = false;
        //PlayerMove.speed = 0;
    }
}
