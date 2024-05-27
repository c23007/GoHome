using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChesokusiSC : MonoBehaviour
{
    public Rigidbody Chekugi;
    float SP = 30000;
    public SisoSC sisosc;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player" && sisosc.sisoCO > 0)
        {
            Chekugi.AddForce(-transform.up * SP);
        }
    }
}
