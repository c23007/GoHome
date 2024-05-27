using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
    public GameObject Enemy;
    int EnemyZ;
    bool Switch1 = false;
    bool Switch2 = false;
    public float EnemyMoveZ;
    float EnemyStartPos;
    

    void Start()
    {
        EnemyStartPos = this.gameObject.transform.position.z;
    }

    void Update()
    {
        EnemyZ = (int)Enemy.transform.position.z;

        if (EnemyZ == (int)EnemyStartPos)
        {
            Switch2 = true;
            Invoke("moveFront", 5.0f);   //�T�b��ɑO�Ɍ����ē����o��
        }

        if (Switch1 == true && Switch2 == true)   //Swich1��Swich2���ǂ���Ƃ�true�̏ꍇ
        {
            Enemy.transform.position =
                new Vector3(Enemy.transform.position.x,
                            Enemy.transform.position.y,
                            Enemy.transform.position.z + Time.deltaTime * 4);
        }

        if (EnemyZ == (int)EnemyStartPos + (int)EnemyMoveZ)
        {
            Switch2 = false;
            Invoke("moveBack", 5.0f);     //�T�b��ɉ��Ɍ����ē����o��
        }

        if (Switch1 == false && Switch2 == false)     //Swich1��Swich2���ǂ���Ƃ�false�̏ꍇ
        {
            Enemy.transform.position =
                new Vector3(Enemy.transform.position.x,
                            Enemy.transform.position.y,
                            Enemy.transform.position.z - (Time.deltaTime * 4));
        }
        /*Debug.Log(EnemyZ);
        Debug.Log(Switch1);
        Debug.Log(Switch2);*/
    }

    public void moveFront()
    {
        Switch1 = true;
    }

    public void moveBack()
    {
        Switch1 = false;
    }
}
