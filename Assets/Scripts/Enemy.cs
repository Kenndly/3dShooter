using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float HP = 30f;
    public float enemydamage = 10f;
    public Transform player;
    public float AgrRange=10f;
    NavMeshAgent agent;
    public PlayerCHar _player;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void TakeDamage(float a)
    {
        HP -= a;
        if (HP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }


    private void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);
        if ( distance<=AgrRange)
        {
            agent.SetDestination(player.position);
        }
        Debug.Log(distance);

       if(distance<=2f)       
        {
            _player.TakeDamage(enemydamage);
            Debug.Log(_player.HP);
        }
    }


}
