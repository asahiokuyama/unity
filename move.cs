using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;　//UIのヘッダファイルをインクルード

public class move : MonoBehaviour
{

    GameObject fintext;//テキストを扱うGameObject型の変数を用意
    
 	void Start() {
		fintext = GameObject.Find("Text");//上の変数にUnity内のテキストを格納
   	}
	
	void Update () {//関係ない
 
// 		float dy = Input.GetAxis("Vertical");
// 		float dx = Input.GetAxis("Horizontal");
 
// 		if (Input.GetKey("up")) {
// 			transform.Translate(0, dy, 0);
// 		}
 
// 		if (Input.GetKey("down")) {
// 			transform.Translate(0, dy, 0);
// 		}
 
// 		if (Input.GetKey("left")) {
// 			transform.Translate(dx, 0, 0);
// 		}
 
// 		if (Input.GetKey("right")) {
// 			transform.Translate(dx*Time.deltaTime, 0, 0);
// 		}
		transform.position += new Vector3(Input.GetAxis("Vertical"),0,0);
	}


    private void OnCollisionEnter(Collision other) {//当たった時
    
        if(other.gameObject.CompareTag("fin")){//もし当たったオブジェクトのタグが〇〇なら
            fintext.GetComponent<Text>().text = "あたった！！";//変数内のTextを取得、Text内のtextを変更。
        }
    }
}
