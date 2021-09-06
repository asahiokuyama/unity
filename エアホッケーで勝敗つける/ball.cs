using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1;

    GameObject win_text;

    bool gameset = false;
    // Start is called before the first frame update
    void Start()
    {
        var power = (transform.right) * speed;
        rb.AddForce(power, ForceMode.Impulse);

        win_text = GameObject.Find("win");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(gameset == false)
        {
            if (collision.gameObject.CompareTag("win1"))
            {
                win_text.GetComponent<Text>().text = "Player1のかち";
                gameset = true;
            }
            if (collision.gameObject.CompareTag("win2"))
            {
                win_text.GetComponent<Text>().text = "Player2のかち";
                gameset = true;
            }
        }

    }
}
