using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//ここ

public class ballmove : MonoBehaviour
{
    public Rigidbody rb;
    
    
    
    ///////////////////ここ
    GameObject count_text;

    int count_number = 0;
    //////////////////
    

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, -5, ForceMode.Impulse);
        
        

           ////////////////ここ
        count_text = GameObject.Find("count");
        //////////////
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(count_number);
        
        
        
        /////////////////////////ここ
        if (count_number < 4)
        {
            count_text.GetComponent<Text>().text = "Breaked block:" + count_number;
        }
        else
        {
            count_text.GetComponent<Text>().text = "FIN!!";
        }
        ////////////////////////////
        
        
        
    }
    
    
    

     ////////////////////////////////ここ
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("block"))
        {
            count_number++;
        }
    }
    ///////////////////////////////////
    
    
    

}
