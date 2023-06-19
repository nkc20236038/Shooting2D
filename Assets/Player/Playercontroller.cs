using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    Vector3 dir = Vector3.zero; //移動方向を保持する変数
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //アニメーターコンポーネントの情報を保存
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5;

        //移動方向をセット
        dir.x = Input.GetAxisRaw("Horizontal");
        dir .y= Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        //画面内移動制限
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        if (dir.y ==0 )
            //アニメーションクリップ「Player」を再現
        {
            anim.Play("Player");
        }
        else if (dir.y ==1)
        {
            anim.Play("PlayerL");
        }
        else if (dir.y == -1)
        {
            anim.Play("PlayerR");
        }



    }
}
