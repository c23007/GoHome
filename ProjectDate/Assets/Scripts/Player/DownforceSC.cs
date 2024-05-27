using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownforceSC : MonoBehaviour
{
    Vector3 startTouchPos;
    Vector3 endTouchPos;
    public Rigidbody Player;
    float flickValue_x;
    float flickValue_y;
    Rigidbody player_rb;
    float Downforce = 4000;
    void Start()
    {
        Player = GetComponent<Rigidbody>();
    }

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
    }

    void FlickDirection()
    {       
        flickValue_y = endTouchPos.y - startTouchPos.y;
    }

    void GetDirection()
    {
        if (flickValue_y < -100)
        {
            Player.AddForce(-transform.up * Downforce);
        }
    }
}