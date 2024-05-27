using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SokusiSC : MonoBehaviour
{
    public GameObject Player;
    public GameObject start;
    public GameObject check;
    public ReSpornSC respornSC;
    public GameObject Bikkuri;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            if (respornSC.checktimer == 0)
            {
                Bikkuri.SetActive(true);
                Player.transform.position = start.transform.position;
                Invoke("Bikkurifalse", 1);
            }
            else
            {
                Bikkuri.SetActive(true);
                Player.transform.position = check.transform.position;
                Invoke("Bikkurifalse", 1);
            }
        }
    }
    void Bikkurifalse()
    {
        Bikkuri.SetActive(false);
    }
}
