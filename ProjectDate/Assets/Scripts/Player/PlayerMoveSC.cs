using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class PlayerMoveSC : MonoBehaviour
{
    public Rigidbody PlayerRB;
    public float PlayerSP;
    public BoxCollider Back;
    public Camera nowcom;
    bool isGraund;
    Transform ViewX;
    Transform MousePos;
    bool PlayerMoveCheck = false;
    void Start()
    {
        Back = GetComponent<BoxCollider>();
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isGraund)
        {
            PlayerMoveCheck = true;
            Vector3 mousePos = Input.mousePosition;
            Vector3 tachepos = nowcom.ScreenToViewportPoint(mousePos);
            if (tachepos.x < 0.5)
            {
                PlayerRB.AddForce(-transform.forward * PlayerSP);
                Back.material.dynamicFriction = 2.0f;
            }
            if (tachepos.x >= 0.5 )
            {
                PlayerRB.AddForce(transform.forward * PlayerSP);
                Back.material.dynamicFriction = 0.8f;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Grand"))
        {
            isGraund = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Grand"))
        {
            isGraund = true;
        }
    }
}




   