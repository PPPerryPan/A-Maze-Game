using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	//引用场景管理器

public class shooing4_5 : MonoBehaviour {
	
	// 碰撞盒：
	void OnCollisionEnter(Collision col){	// 进入
		if(Script_Manager4.insManager.Score_int == 10){
			Destroy(this.gameObject);
			SceneManager.LoadScene(4);
		}
		
	}
}
