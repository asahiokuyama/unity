using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("Spawn",0f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Spawn();
        }
    }

    public void Spawn(){
        Instantiate(ball,transform.position,transform.rotation);
    }
}
