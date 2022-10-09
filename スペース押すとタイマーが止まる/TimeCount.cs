using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCount : MonoBehaviour
{
    float timecount = 0;
    bool state = true;
    int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //boolを使ったやり方(こっちの方が使われる
        //Debug.Log(state);
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if(state == true)
        //    {
        //        state = false;
        //    }else if(state == false)
        //    {
        //        state = true;
        //    }
        //}

        //if(state == true)
        //{
        //    timecount += Time.deltaTime;
        //}

        //intを使ったやり方（こっちの方が簡単で算数の勉強になる
        if (Input.GetKeyDown(KeyCode.Space))
        {
            number++;
        }

        if(number%2 == 0)
        {
            timecount += Time.deltaTime;
        }
        
        Debug.Log((int)timecount);
    }
}
