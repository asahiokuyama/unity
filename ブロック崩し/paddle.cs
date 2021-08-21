using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public float speed = 10;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, Input.GetAxis("Horizontal")*speed*Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("speedup")){
            ball.GetComponent<ball>().velocity_up();
        }
    }
}
