using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyNav : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform posicionNueva;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(posicionNueva.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
