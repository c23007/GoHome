using UnityEngine;
using UnityEngine.EventSystems;

public class SekiroSC : MonoBehaviour, IPointerClickHandler
{
    public GameObject Player;
    public GameObject Jump;
    public Vector3 thisPos;
    public GameObject Himo;


    void Update()
    {
        thisPos = this.gameObject.transform.position;
       // Instantiate(Himo, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
    }

    // �N���b�N���ꂽ�Ƃ��ɌĂяo����郁�\�b�h
    public void OnPointerClick(PointerEventData eventData)
    {
        Player.transform.position = thisPos;
        
            
    }
}