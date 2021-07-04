using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    GameObject fintext;
    // Start is called before the first frame update
    void Start()
    {
        fintext = GameObject.Find("Fin");
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(Input.GetAxis("Vertical")*Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("fin1"))
        {
            fintext.GetComponent<Text>().text = "GameClear";
        }

        if (collision.gameObject.CompareTag("fin2"))
        {
            SceneManager.LoadScene("gameclear");
        }
        
    }
}
