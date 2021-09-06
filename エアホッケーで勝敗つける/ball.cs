using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//テキストを扱うために入れる

public class ball : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1;


    GameObject win_text;//テキストをGameObjectで扱うためにGameObject型の変数をつくる

    bool gameset = false;//ロックをかけるためのbool変数をつくる
    // Start is called before the first frame update
    void Start()
    {
        var power = (transform.right) * speed;
        rb.AddForce(power, ForceMode.Impulse);

        win_text = GameObject.Find("win");//上でつくった変数に、Unity内のTextをいれる
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)//ぼーるが何かにふれたとき
    {
        if(gameset == false)//もしgamesetがfalseなら(ここでロックしている)
        {
            if (collision.gameObject.CompareTag("win1"))//もし当たったもののタグがwin1なら
            {
                win_text.GetComponent<Text>().text = "Player1のかち";//win_text内のText要素のtextを、、、
                gameset = true;//gamesetをtrueにして以後はいらなくする
            }
            if (collision.gameObject.CompareTag("win2"))//上に同じ
            {
                win_text.GetComponent<Text>().text = "Player2のかち";
                gameset = true;
            }
        }

    }
}
