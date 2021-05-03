using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	//引用场景管理器

public class Start_Quit : MonoBehaviour {

	public void On_Start(){
		SceneManager.LoadScene(1);	//异步加载关卡（可返回int类型）
	}
	public void On_Quit(){
		Application.Quit();	//调用应用程序.退出
	}
	public void On_Exit(){
		SceneManager.LoadScene(0);
	}
	public void Go_4(){
		SceneManager.LoadScene(3);
	}
}
