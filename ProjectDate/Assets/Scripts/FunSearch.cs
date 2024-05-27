using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FunSearch : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    Vector3 direction;   // Ray���΂�����
    float distance = 10;    // Ray���΂�����
    float timer = 0;
    private float step_time;
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("player"))
        {
            // Ray���΂��������v�Z
            Vector3 temp = other.transform.position - transform.position;    //�v���C���[�̍��W����G�̍��W������
            direction = temp.normalized;

            ray = new Ray(transform.position, direction);  // Ray���΂�
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.red);  // Ray���V�[����ɕ`��

            // Ray���ŏ��ɓ����������̂𒲂ׂ�
            if (Physics.Raycast(ray.origin, ray.direction * distance, out hit))
            {
                if (hit.collider.CompareTag("player"))    //�q�b�g�����I�u�W�F�N�g�̃^�O���v���C���[�̏ꍇ
                {
                    Debug.Log("�v���C���[����" + timer);
                    timer += Time.deltaTime;
                    { 
                        if (timer > 3)     //�R�b����
                        {
                            Debug.Log("����");
                            SceneManager.LoadScene("Result");  //Result�V�[���ɑJ�ڂ���
                        }
                    }
                }
                else      //�Ⴄ�ꍇ
                {
                    Debug.Log("�v���C���[�Ƃ̊Ԃɕǂ�����");
                    timer = 0;
                }
            }
        }
    }
}


   
    




    
