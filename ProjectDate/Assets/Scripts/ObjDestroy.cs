using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDestroy : MonoBehaviour
{
    private GameObject parentObj;

    void Start()
    {
        parentObj = transform.parent.gameObject;      //�e�I�u�W�F�N�g���擾
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Plane")        //�Ԃ������I�u�W�F�N�g�̖��O��Plane�Ȃ�
        {
            Destroy(parentObj);                     //�e�I�u�W�F�N�g��Destroy����
        }
    }
}
