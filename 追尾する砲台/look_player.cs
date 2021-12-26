using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_player : MonoBehaviour
{
    public GameObject targert;//targetを入れる変数

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //是非この値も見てみてください
        Debug.Log(transform.rotation.x );
        
        //ずっとこのオブジェクトはtargetを追って回転する
        transform.LookAt(targert.transform);
        
        if(transform.rotation.x <=-0.3){//上側
            this.transform.localEulerAngles = new Vector3(-30,0,0);
        }else if(transform.rotation.x >= 0.3{//下側
            this.transform.localEulerAngles = new Vector3(30,0,0);
        }
    }
}
