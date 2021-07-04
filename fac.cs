using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fac : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }
}
