using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpornSC : MonoBehaviour
{
    public Vector3 NowRespornPoint;
    public int checktimer;
    void Start()
    {
        checktimer = 0;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            checktimer ++;
        }
    }
}
