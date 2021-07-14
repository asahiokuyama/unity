using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{
    float speed = 3.0f;

    GameObject uicon;
    // Start is called before the first frame update
    void Start()
    {
        uicon = GameObject.Find("UIController");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,0,speed*Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("enemy")){
            Destroy(this.gameObject);
            uicon.GetComponent<uicontroller>().hp_down();
        }
    }
}
