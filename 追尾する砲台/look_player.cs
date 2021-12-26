using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_player : MonoBehaviour
{
    public GameObject targert;//targetを入れる変数
    bool rock = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(targert.transform.rotation.x );
        
        //ずっとこのオブジェクトはtargetを追って回転する
        transform.LookAt(targert.transform);
        
        //ここがポイントで、変数をつかって疑似ロック的なことをしている。これをしないと正常に動かない
        if(rock == false){
            if(transform.rotation.x <=-0.3){
                rock = true;
              
            }
        }
        if(rock == true){
            this.transform.localEulerAngles = new Vector3(-30,0,0);
            rock = false;
        }
     
            
        //
        
    }
}
