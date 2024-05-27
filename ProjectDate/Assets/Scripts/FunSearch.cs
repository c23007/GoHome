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
    Vector3 direction;   // Rayを飛ばす方向
    float distance = 10;    // Rayを飛ばす距離
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
            // Rayを飛ばす方向を計算
            Vector3 temp = other.transform.position - transform.position;    //プレイヤーの座標から敵の座標を引く
            direction = temp.normalized;

            ray = new Ray(transform.position, direction);  // Rayを飛ばす
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.red);  // Rayをシーン上に描画

            // Rayが最初に当たった物体を調べる
            if (Physics.Raycast(ray.origin, ray.direction * distance, out hit))
            {
                if (hit.collider.CompareTag("player"))    //ヒットしたオブジェクトのタグがプレイヤーの場合
                {
                    Debug.Log("プレイヤー発見" + timer);
                    timer += Time.deltaTime;
                    { 
                        if (timer > 3)     //３秒たつと
                        {
                            Debug.Log("死んだ");
                            SceneManager.LoadScene("Result");  //Resultシーンに遷移する
                        }
                    }
                }
                else      //違う場合
                {
                    Debug.Log("プレイヤーとの間に壁がある");
                    timer = 0;
                }
            }
        }
    }
}


   
    




    
