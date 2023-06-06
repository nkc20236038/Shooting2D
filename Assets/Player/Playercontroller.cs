using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    Vector3 dir = Vector3.zero; //�ړ�������ێ�����ϐ�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5;

        //�ړ��������Z�b�g
        dir.x = Input.GetAxisRaw("Horizontal");
        dir .y= Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        //��ʓ��ړ�����
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;


    }
}