using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class AITarget : MonoBehaviour
{
    public NavMeshAgent agent;
    public NavMeshAI character;
    public Transform target;

    void Start()
    {
        agent.updateRotation = false;
    }

    void Update()
    {

        
        agent.SetDestination(target.position);
        
        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }
        
        
    }
}
