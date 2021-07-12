using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator anim;// Animatorを使うための変数

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();// animにAnimatorの値を取得して代入
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))// もし、スペースキーが押されたら、
        {
            anim.SetBool("throw", true);// AnimatorのAttackをtrueにする
        }

        else if(Input.GetKeyUp(KeyCode.Space))// もし、スペースキーが離されたら、
        {
            anim.SetBool("throw", false);// Attackをfalseにする
        }
    }
}