using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDestroy : MonoBehaviour
{
    private GameObject parentObj;

    void Start()
    {
        parentObj = transform.parent.gameObject;      //親オブジェクトを取得
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Plane")        //ぶつかったオブジェクトの名前がPlaneなら
        {
            Destroy(parentObj);                     //親オブジェクトをDestroyする
        }
    }
}
