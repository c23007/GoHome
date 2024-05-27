using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SisoSC : MonoBehaviour
{
    public GameObject Kugi;
    public GameObject Siso1;
    public GameObject Siso2;
    public Rigidbody KugiRB;
    float SP = 30000;
    public int sisoCO = 0;
    void Start()
    {
        Siso2.SetActive(false);
    }

    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            Siso1.SetActive(false);
            Siso2.SetActive(true);
            KugiRB.AddForce(transform.up * SP);
            Invoke("KugiFalse", 2);
            sisoCO++;
        }
    }
    void KugiFalse()
    {
        Kugi.SetActive(false);
    }
    public void Counter()
    {
        sisoCO++;
    }
}
