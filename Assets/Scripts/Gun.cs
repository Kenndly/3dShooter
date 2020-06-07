using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range =100f;
    public float firerate = 15f;
    private float timefire = 0f;
    public Camera fpsCam;
    Enemy enemy;

    void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range);
        enemy = hit.transform.GetComponent <Enemy>();
        if(enemy!=null)
        {
            enemy.TakeDamage(damage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")&&Time.time>=timefire)
        {
            timefire = Time.time + 1f/firerate;
            Shoot(); 
            
        }
    }
}
