using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickpanel : MonoBehaviour
{
    GameObject[] redobjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickAct(){
        Debug.Log("クリック");
        redobjects = GameObject.FindGameObjectsWithTag("red");
                for (int i = 0; i < redobjects.Length; i++)
                {
                    Destroy(redobjects[i]);
                }
    }
}
