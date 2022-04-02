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
        //假设我在区间内左右循环移动
        if(movingRight)
        {
            //我正在右移
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            //如果我到了正区间，那么接下去就是反方向移动
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
