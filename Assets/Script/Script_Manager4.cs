using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	//引用UI命名空间

public class Script_Manager4 : MonoBehaviour {

	public static Script_Manager4 insManager; //提供外部访问
	public Text Score_Text;
	public int Score_int;

	public AudioSource Source;

	// Use this for initialization
	void Start () {
		insManager = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
