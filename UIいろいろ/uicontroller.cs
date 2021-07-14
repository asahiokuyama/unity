using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uicontroller : MonoBehaviour
{
    GameObject enemy_hp;
    int hp = 10;
    // Start is called before the first frame update
    void Start()
    {
        enemy_hp = GameObject.Find("enemy_hp");
    }

    // Update is called once per frame
    void Update()
    {
        if(hp > 0){
            enemy_hp.GetComponent<Text>().text = "HP:" + hp;
        }else{
            enemy_hp.GetComponent<Text>().text = "Fin!!";
        }
    }

    public void hp_down(){
       hp--;
    }

    public void point_reset(){
        hp = 10;
    }
}
