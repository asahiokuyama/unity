using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    bool isladder = false;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime,0,0);
        if(isladder == true){
            transform.position += new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime,Input.GetAxis("Vertical")*Time.deltaTime,0);
            rb.useGravity = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ladder")){
            isladder = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("Ladder")){
            isladder = false;
            rb.useGravity  = true;
        }
    }
}
