using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KariEnemySC : MonoBehaviour
{
    public GameObject Player;
    public GameObject start;
    public GameObject check;
    public ReSpornSC respornSC;
    float MoveTimer;
    int DeadTache = 0;
    public GameObject Bikkuri;
    public Rigidbody PlayerRB2;
    float Down = 10000;
    float Down2 = 2000;
    public GameObject Enemy;
    public GameObject Enemy2;
    bool isRotate = true;
    void Start()
    {
        Bikkuri.SetActive(false);
    }

    void Update()
    {
        MoveTimer += Time.deltaTime;
        if (MoveTimer > 3 && isRotate)
        {
            Enemy.SetActive(false);
            Enemy2.SetActive(true);
            isRotate = false;
        } 
        if (MoveTimer > 4)
        {            
            Enemy2.SetActive(false);
            Enemy.SetActive(true);
            isRotate = true;
            MoveTimer = 0;
            //Debug.Log("nanati");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            if (Input.GetMouseButtonDown(0))
            {
                DeadTache++;
                if(DeadTache >= 6)
                {
                    if (respornSC.checktimer == 0)
                    {
                        Bikkuri.SetActive(true);
                        Player.transform.position = start.transform.position;
                        PlayerRB2.AddForce(-transform.up * Down);
                        Invoke("Bikkurifalse",1);
                    }
                    else
                    {
                        Bikkuri.SetActive(true);
                        Player.transform.position = check.transform.position;
                        PlayerRB2.AddForce(-transform.up * Down2);
                        Invoke("Bikkurifalse", 1);

                    }
                }
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            DeadTache = 0;
        }
    }
    void Bikkurifalse()
    {
        Bikkuri.SetActive(false);
    }

}
