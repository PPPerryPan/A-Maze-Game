using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goTest : MonoBehaviour {

    private Animator ani;//动画控制器
	void Start () 
    {
        ani = this.GetComponent<Animator>();//获取动画控制器组件（泛型）
	}
	
	// Update is called once per frame
	void Update () 
    {
		if(Input.GetKey(KeyCode.W))
        {
            ani.SetBool("runtree",true);
            this.transform.Translate(Vector3.forward*9*Time.deltaTime);  //移动
        }
        else
        {
            ani.SetBool("runtree",false); 
        }

        if(Input.GetKey(KeyCode.R))
        {
            ani.Play("WAIT01",0,0f);
        }

        if (Input.GetKey(KeyCode.T))
        {
            ani.Play("WAIT02", 0, 0f);
        }

        if (Input.GetKey(KeyCode.Y))
        {
            ani.Play("WAIT03", 0, 0f);
        }

        if (Input.GetKey(KeyCode.U))
        {
            ani.Play("WAIT04", 0, 0f);
        }

     
        moveLR();
        
	}

    void moveLR()
    {
        float H = Input.GetAxis("Horizontal");  //获取轴
        ani.SetFloat("Blend",H);
        this.transform.Rotate(new Vector3(0,H,0)); //旋转
    }
}
