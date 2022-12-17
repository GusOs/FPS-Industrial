using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    //Transform del enemigo
    public Transform player;

    //Daño de ataque
    public int bitteAttack = 5;

    //Distancia de detección
    public float distance = 45f;

    //Animator del enemigo
    public Animator anim;

    UnityEngine.AI.NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        checkAnimation();
    }

    public void checkAnimation()
    {
        if (Vector3.Distance(player.position, this.transform.position) < distance)
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);


            if (direction.magnitude < 60)
            {
                nav = GetComponent<NavMeshAgent>();
                nav.isStopped = false;
                anim.SetBool("attack", false);
                anim.SetInteger("moving", 9);
                nav.SetDestination(player.position);
            }

            if (direction.magnitude < 4f)
            {
                anim.SetInteger("moving", 0);
                nav = GetComponent<NavMeshAgent>();
                nav.isStopped = true;
                anim.SetBool("attack", true);
            }
        }
    }
}
