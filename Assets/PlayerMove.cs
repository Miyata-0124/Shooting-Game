using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーのワールド座標取得
        Vector3 pos = transform.position;

        //右矢印が押されたとき
        if(Input.GetKey(KeyCode.RightArrow))
        {
            //右に0.01f
            pos.x += 0.01f;
        }
        //左矢印が押されたとき
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //左に0.01f
            pos.x -= 0.01f;
        }
        //上矢印が押されたとき
        if(Input.GetKey(KeyCode.UpArrow))
        {
            //上に0.01f
            pos.z += 0.01f;
        }
        //下矢印が押されたとき
        if(Input.GetKey(KeyCode.DownArrow))
        {
            //下に0.01f
            pos.z -= 0.01f;
        }
        transform.position=new Vector3(pos.x, pos.y, pos.z);
    }
}
