using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    GameObject fintext;
    void Start() {
        fintext = GameObject.Find("Text");
    }
void Update () {
 
		float dy = Input.GetAxis("Vertical");
		float dx = Input.GetAxis("Horizontal");
 
		if (Input.GetKey("up")) {
			transform.Translate(0, dy, 0);
		}
 
		if (Input.GetKey("down")) {
			transform.Translate(0, dy, 0);
		}
 
		if (Input.GetKey("left")) {
			transform.Translate(dx, 0, 0);
		}
 
		if (Input.GetKey("right")) {
			transform.Translate(dx*Time.deltaTime, 0, 0);
		}
	}

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("fin")){
            fintext.GetComponent<Text>().text = "あたった！！";
        }
    }
}
