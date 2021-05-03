using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shooing_gameover : MonoBehaviour {

	private Rigidbody Rig;	//刚体
	void Start () {
		Rig = GetComponent<Rigidbody>();	//获取刚体
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col){	// col 被碰撞的物体
		if (col.gameObject.tag == "Player")
		{
			Destroy(col.gameObject);
			SceneManager.LoadScene(5);
		}
	}
}
