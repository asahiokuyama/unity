using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptB : MonoBehaviour
{
    int B;//数字を扱うためint型の変数をつくる
    ScriptA number;//ScriptA型の変数をつくる
    // Start is called before the first frame update
    void Start()
    {
        number = GetComponent<ScriptA>();//上で作った変数にScriptAをひもづける
    }

    // Update is called once per frame
    void Update()
    {
        B = number.A;//number.AでScriptAの中のAという変数を呼び出せる。
        print(B);   
    }
}
