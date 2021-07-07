using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //変数「pos」をつくる
        Vector3 pos;
        //変数「pos」に変数「rb」(PlayerのRigidbody)の座標をセットする
        pos = rb.position;
        //変数「pos」のx座標にマウスのx座標を3D空間の座標に変換してセットする
        pos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward * 0.5f).x;
        //変数「rb」(PlayerのRigidbody)のMovePositionに変数「pos」の値をセットする
        rb.MovePosition(pos);

        //Vector3型の変数「vel」をつくる
        Vector3 vel;
        //「vel」に変数rb(PlayerのRigidbodyのvelocity（速さ）をセットする)
        vel = rb.velocity;
        //「vel」のz座標に3をセットする
        vel.z = 3;
        //「rb」(PlayerのRigidbodyのvelocity(速さ)に「vel」 の情報をセットする
        rb.velocity = vel;
    }
}
