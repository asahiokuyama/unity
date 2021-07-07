using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    Vector3 pos;
    void Start()
    {
        player = GameObject.Find("Player");
        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //「pos」 のz座標だけを現在のプレイヤーのz座標に-2してセットする
        pos.z = player.transform.position.z - 8;

        //ここがないところ
        pos.y = player.transform.position.y + 5;
        pos.x = player.transform.position.x;


        //現在のカメラの座標に「pos」 をセットする
        gameObject.transform.position = pos;
    }
}
