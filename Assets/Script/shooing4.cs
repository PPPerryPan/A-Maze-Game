using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shooing4 : MonoBehaviour {
	private Rigidbody Rig;	//刚体
	// Use this for initialization
	void Start () {
		Rig = GetComponent<Rigidbody>();	//获取刚体
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col){	// col 被碰撞的物体
			Destroy(this.gameObject);
			Script_Manager4.insManager.Source.Play();
			Script_Manager4.insManager.Score_int += 1;
			Script_Manager4.insManager.Score_Text.text = Script_Manager4.insManager.Score_int.ToString();
	}
}
