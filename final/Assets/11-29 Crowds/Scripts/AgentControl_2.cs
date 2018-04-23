using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentControl_2 : MonoBehaviour {

	NavMeshAgent agent;
	GameObject[] targets;
	Vector3 target;

	void Start () {
		agent = GetComponent<NavMeshAgent>();
		targets = GameObject.FindGameObjectsWithTag("NavTarget");
		GetTarget();
	}

	void Update () {
		if(Vector3.Distance(target, transform.position) < 3f){
			GetTarget();
		}
	}

	void GetTarget(){
		target = targets[Random.Range(0, targets.Length)].transform.position;
		agent.SetDestination(target);
	}
}
