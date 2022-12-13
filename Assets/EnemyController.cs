using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform target_player;
    public NavMeshAgent enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(target_player.position);//Playerを追いかける（移動先を指定）
    }
}
