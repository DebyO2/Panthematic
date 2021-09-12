using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject car;
    private bool cantrace;
    void Start()
    {
        
        agent = gameObject.GetComponent<NavMeshAgent>();
        car = GameObject.Find("Car");
        cantrace = true;
        return;
    }

    
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length >= 1)
        {
            StartCoroutine(spawn());
        }
        
    }

    IEnumerator spawn()
    {
        yield return new WaitForSeconds(5);

        if (cantrace)
        {
            agent.SetDestination(car.transform.position);
        }

    }
}
