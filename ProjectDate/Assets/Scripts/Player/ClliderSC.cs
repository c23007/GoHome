using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClliderSC : MonoBehaviour
{
    float endTimer;
    public bool isJump = false;
    float jumpPower = 1500f;   
    float jumpPower2 = 1800;    
    float jumpPower3 = 2300;   
    public Rigidbody PlayerRB;
    float isMouseTimer;
    public float DownForcePower;
    float flickValue_y;
    Vector3 endTouchPos;
    Vector3 startTouchPos;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startTouchPos = new Vector3(0, Input.mousePosition.y, 0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            endTouchPos = new Vector3(0, Input.mousePosition.y, 0);
            FlickDirection();
            GetDirection();
        }
        if (Input.GetMouseButtonUp(0))
        {
            GetDirection();
            isMouseTimer = 0;
        }
        if (Input.GetMouseButton(0))
        {
            isMouseTimer += Time.deltaTime;
            endTimer = isMouseTimer;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Grand"))
        {
            isJump = false;
        }
    }
     void GetDirection()
    {
        if (flickValue_y > 20 && !isJump && flickValue_y <=80)
        {
            Jump1();
        }
        if (flickValue_y > 80 && !isJump && flickValue_y <= 130)
        {
            Jump2();
        }
        if (flickValue_y > 130 && !isJump)
        {
            Jump3();
        }
    }
    void Jump1()
    {
        PlayerRB.AddForce(transform.up * (jumpPower));
        isJump = true;
        Invoke("DownForce", 1);
    }
    void Jump2()
    {
        PlayerRB.AddForce(transform.up * (jumpPower2));
        isJump = true;
        Invoke("DownForce", 1);
    }
    void Jump3()
    {
        PlayerRB.AddForce(transform.up * (jumpPower3));
        isJump = true;
        Invoke("DownForce", 1);
    }
    void DownForce()
    {
        PlayerRB.AddForce(-transform.up * DownForcePower);
    }
    void FlickDirection()
    {
        flickValue_y = endTouchPos.y - startTouchPos.y;
    }
}

