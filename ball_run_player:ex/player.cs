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
        Vector3 pos;
        pos = rb.position;
        //変数「pos」のx座標にマウスのx座標を3D空間の座標に変換してセットする
        pos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward * 0.5f).x;
        //変数「rb」(PlayerのRigidbody)のMovePositionに変数「pos」の値をセットする
        rb.MovePosition(pos);

        Vector3 vel;
        vel = rb.velocity;
        vel.z = 3;
        rb.velocity = vel;
    }
}
