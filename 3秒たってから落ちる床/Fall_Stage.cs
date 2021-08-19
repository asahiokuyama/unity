using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_Stage : MonoBehaviour
{
    GameObject rb;//RigidBodyを使うための変数

    float wait_time = 0;//3秒をカウントする変数

    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.Find("Fall_Stage");//rbにステージを入れる
    }

    // Update is called once per frame
    void Update()
    {
        if(wait_time <= 3.0f)//もし時間が3秒以下だったら==つまり触れていないときは、すべてフリーズさせておく。
        {
            rb.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        else
        {//3秒経過したら、freezeを解除したあとrotationだけ固定
            rb.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            rb.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        Debug.Log(wait_time);
    }


    private void OnCollisionStay(Collision collision)//Plyerタグのオブジェクトに”触れている間”はwait_timeに時間を足していく
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wait_time += Time.deltaTime;
        }
    }
    private void OnCollisionExit(Collision collision)//Plyerタグのオブジェクトから”離れたとき"はwait_timeをリセットさせる。
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wait_time = 0;
        }
    }
}
