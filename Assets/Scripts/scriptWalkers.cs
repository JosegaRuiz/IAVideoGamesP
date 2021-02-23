using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class scriptWalkers : MonoBehaviour
{

    private Rigidbody rb;

    [Header("AISettings")]
    public Vector3 Positions = new Vector3(0, 0, 0);
    public float RandomXposition = 0;
    public float RandomZposition = 0;
    public NavMeshAgent Walker;


    void Start()
    {

        SetTarget();

    }

    // Update is called once per frame
    void Update()
    {

        Positions = new Vector3(RandomXposition, transform.position.y, RandomZposition);

        Walker.SetDestination(Positions);

        if (transform.position == Positions)
        {
            SetTarget();
        }
    }

    void SetTarget()
    {
        RandomXposition = Random.Range(20, -20);
        RandomZposition = Random.Range(20, -20);
    }
}
