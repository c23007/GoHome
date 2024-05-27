using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField] GameObject pole;
    Rigidbody rb;
    public float Speed;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            rb = pole.GetComponent<Rigidbody>();      //Rigidbody‚ðŽæ“¾
            rb.velocity = -transform.forward.normalized * Speed;
        }
    }
}