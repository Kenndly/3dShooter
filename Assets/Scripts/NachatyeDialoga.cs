using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachatyeDialoga : MonoBehaviour
{
    bool Da;
    public GameObject dialog, player;
    float distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(gameObject.transform.position, player.transform.position)< 2)
        {
            dialog.SetActive(true);
        }
    }
}
