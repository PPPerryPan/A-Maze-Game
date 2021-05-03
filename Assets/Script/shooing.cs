using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	//引用场景管理器

public class shooing : MonoBehaviour {
	
	// 碰撞盒：
	void OnCollisionEnter(Collision col){	// 进入
		Destroy(this.gameObject);
		Go_3();
	}

	void OnCollisionExit(Collision colexit){	// 结束
		Destroy(this.gameObject);
		Go_3();	
	}
	public void Go_3(){
		SceneManager.LoadScene(4);
	}
}
