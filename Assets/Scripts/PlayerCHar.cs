using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCHar : MonoBehaviour
{
    public float HP = 100f;
    // Start is called before the first frame update
    public void TakeDamage(float a)
    {
        HP -= a;
        if(HP<=0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
    }
}
