//①Scene遷移を選択した場合
//②UI表示を選択した場合
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//①

public class move : MonoBehaviour
{
    GameObject fintext;//②
    // Start is called before the first frame update
    void Start()
    {
        fintext = GameObject.Find("Fin");//②
    }

    // Update is called once per frame
    void Update()
    {
        //これ関係ない
        transform.position += new Vector3(Input.GetAxis("Vertical")*Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //②
        if (collision.gameObject.CompareTag("fin1"))
        {
            fintext.GetComponent<Text>().text = "GameClear";
        }
        
        //①
        if (collision.gameObject.CompareTag("fin2"))
        {
            SceneManager.LoadScene("gameclear");
        }
        
    }
}
