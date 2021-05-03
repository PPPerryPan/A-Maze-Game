using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorRun : MonoBehaviour
{
    public Animator ani; //声明动画控制器
	void LateUpdate()
    {
        if ( (ETCInput.GetAxis("Vertical") != 0 || ETCInput.GetAxis("Horizontal") != 0))
        {
           //默认执行真
           ani.SetBool("runtree",true); //开始跑
        }

        if ( ETCInput.GetAxis("Vertical") == 0 && ETCInput.GetAxis("Horizontal") == 0)
        {
            //默认执行假
           ani.SetBool("runtree",false);
        }

	}
    public void PlayeButton_A()
    {
        // 动画名 动画所在层 什么时候开始播放
        ani.Play("WAIT01",0,0f);
    }
    public void PlayeButton_B()
    {
        // 动画名 动画所在层 什么时候开始播放
        ani.Play("WAIT02",0,0f);
    }
    public void PlayeButton_C()
    {
        // 动画名 动画所在层 什么时候开始播放
        ani.Play("WAIT03",0,0f);
    }
    public void PlayeButton_D()
    {
        // 动画名 动画所在层 什么时候开始播放
        ani.Play("WAIT04",0,0f);
    }
}
