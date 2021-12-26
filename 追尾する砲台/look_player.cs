using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_player : MonoBehaviour
{
    public GameObject targert;
    bool rock = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(targert.transform.rotation.x );
        

        // if(transform.localEulerAngles.x >= 320){
        //     var aim = targert.transform.position - this.transform.position;
        //     var look = Quaternion.LookRotation(aim);
        //     this.transform.localRotation = look;
        // }else{
        //     this.transform.localEulerAngles = new Vector3(-30,0,0);
        // }&&transform.localEulerAngles.x >=0transform.localEulerAngles.x <= 330&&
        var a = targert.transform;
        transform.LookAt(a);
        if(rock == false){
            if(transform.rotation.x <=-0.3){
                rock = true;
              
            }
        }
        if(rock == true){
            this.transform.localEulerAngles = new Vector3(-30,0,0);
            rock = false;
        }
     
            
        
    }
}
