using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public float speed = 30;
    GameObject botan;
    GameObject point_text;
    GameObject item;

    public int point_count = 0;
    // Start is called before the first frame update
    void Start()
    {
        var power = (transform.forward + transform.right) * 10;
        GetComponent<Rigidbody>().AddForce(power, ForceMode.VelocityChange);

        botan = GameObject.Find("Retry");

        point_text = GameObject.Find("point");
        item = GameObject.Find("item_gen");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= 25)
        {
            botan.GetComponent<Button>().interactable = true;
        }

        if(point_count>=20){
            point_text.GetComponent<Text>().text = "All Clear";
        }else{
            point_text.GetComponent<Text>().text = "壊した数:"+point_count;
        }
        
    }

    public void countup(){
        point_count++;
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("block3")){
            item.GetComponent<item_generator>().speedup_spawn();
        }
    }

    public void velocity_up(){
        // var power = (transform.forward + transform.right) * 10;
        GetComponent<Rigidbody>().AddForce(transform.forward*10, ForceMode.VelocityChange);
    }
}
