using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_Stage : MonoBehaviour
{
    GameObject rb;
    float wait_time = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.Find("Fall_Stage");
    }

    // Update is called once per frame
    void Update()
    {
        if(wait_time <= 3.0f)
        {
            rb.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        else
        {
            rb.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            rb.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        Debug.Log(wait_time);
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wait_time += Time.deltaTime;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wait_time = 0;
        }
    }
}
