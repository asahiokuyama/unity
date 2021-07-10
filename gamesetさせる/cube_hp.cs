using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cube_hp : MonoBehaviour
{
    public int cubehp = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cubehp);
        if(cubehp < 1){
            SceneManager.LoadScene("gameover");
        }
    }

    public void hpdown(){
        cubehp--;
    }
}
