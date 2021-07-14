using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uicontroller : MonoBehaviour
{
    GameObject enemy_hp;
    GameObject reset_button;
    int hp = 10;
    // Start is called before the first frame update
    void Start()
    {
        enemy_hp = GameObject.Find("enemy_hp");
        reset_button = GameObject.Find("reset");
    }

    // Update is called once per frame
    void Update()
    {
        if(hp > 0){
            reset_button.SetActive(false);
            enemy_hp.GetComponent<Text>().text = "HP:" + hp;
        }else{
            reset_button.SetActive(true);
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
