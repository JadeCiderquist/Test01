using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecube : MonoBehaviour
{
    public float speed = 3f;
    private bool movingRight = true;
    void Start()
    {

    }

    private void Update()
    {
        //������������������ѭ���ƶ�
        if(movingRight)
        {
            //����������
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            //����ҵ��������䣬��ô����ȥ���Ƿ������ƶ�
            if(transform.position.z>= 19)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);

            if (transform.position.z<= 1)
            {
                movingRight = true;
            }
        }


    }
}
