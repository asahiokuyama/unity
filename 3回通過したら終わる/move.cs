using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float timer = 0;
    int count = 0;
    bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flag == true){
            timer += Time.deltaTime; 
            Debug.Log("Time:"+(int)timer);
        }
        
        transform.position += new Vector3(Input.GetAxis("Vertical")*Time.deltaTime,0,0);
       
       
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("goal")){
            count++;
            Debug.Log("s");
            if(count >= 3){
            Debug.Log("goal!!!");
            flag = false;
        }
        }
        
    }
}
