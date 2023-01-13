using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptA : MonoBehaviour
{
    public int A;//他のスクリプトで使うのでpublicにする。
    
    // Start is called before the first frame update
    void Start()
    {
        A = 10;
    }

    // Update is called once per frame
    void Update()
    {
           
    }
}
