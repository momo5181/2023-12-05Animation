using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMove : MonoBehaviour
{
    NavMeshAgent agent;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("move",agent.velocity.magnitude);
    }
}
