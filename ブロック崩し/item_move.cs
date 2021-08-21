using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(3*Time.deltaTime,0,0);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("paddle")){
            Destroy(this.gameObject);
        }
    }
}
