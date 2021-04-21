using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Collider[] ragdollColliders;
    [SerializeField] private Collider mainCollider;
    [SerializeField] private Rigidbody[] ragdollRb;
    [SerializeField] private Rigidbody mainRb;
    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private Transform characterTransform;
    [SerializeField] private Transform respawnTransform;
    [SerializeField] private Animator anim;
    


    void Awake()
    {
        characterTransform = GetComponent<Transform>();
        ragdollColliders = GetComponentsInChildren<Collider>();
        mainCollider = GetComponent<Collider>();
        ragdollRb = GetComponentsInChildren<Rigidbody>();
        mainRb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        OnRagdoll(false);
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "RagdollOn")
        {
            OnRagdoll(true);
            Invoke("RespawnPlayers", 1f);
            agent.speed = 0f;
            
        }
    }

    public void RespawnPlayers()
    {
        characterTransform.position = respawnTransform.position;
        OnRagdoll(false);
        agent.speed = Random.Range(1.5f, 2.5f);
    }

    public void OnRagdoll(bool isRagdoll)
    {
        foreach (var childCol in ragdollColliders)
        {
            childCol.enabled = isRagdoll;
            anim.enabled = !isRagdoll;
            mainCollider.enabled = !isRagdoll;
        }

        foreach (var childRb in ragdollRb)
        {
            childRb.useGravity = isRagdoll;
            childRb.freezeRotation = !isRagdoll;
            mainRb.freezeRotation = !isRagdoll;
            mainRb.useGravity = !isRagdoll;
        }
    }
}
