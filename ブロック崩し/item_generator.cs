using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_generator : MonoBehaviour
{
    public GameObject speedup_item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void speedup_spawn(){
        Instantiate(speedup_item,new Vector3(-10,0,-5f),transform.rotation);
    }
}
