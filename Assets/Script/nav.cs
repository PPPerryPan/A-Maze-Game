using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;	//智能

public class nav : MonoBehaviour {

	public Transform transfromposcube;	//要到达的目的地
	private NavMeshAgent agent;	//代理寻路组件
	// Use this for initialization
	void Start () {
		agent = this.GetComponent<NavMeshAgent>();	//获取寻路组件
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination(transfromposcube.position);	//不断寻找目标
	}
}
