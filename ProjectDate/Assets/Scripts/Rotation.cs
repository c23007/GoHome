using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float timeOut;
    float timer = 0;

    void Start()
    {
       
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 5)
        {
         
        } 
        if(timer >= timeOut)
        {
            timer = 0;
        }
    }
}
