using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //ｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰ
    //プレイヤーの移動処理
    //引数　：なし
    //戻り値：なし
    //ｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰ
    private void Move()
    {
        // Aキーで左移動
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-MoveSpeed, 0.0f, 0.0f, Space.World);
        }
        // Dキーで右移動
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(MoveSpeed, 0.0f, 0.0f, Space.World);
        }
    }

    //ｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰ
    //プレイヤーのジャンプ処理
    //引数　：なし
    //戻り値：なし
    //ｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰｰ
    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
        }
    }
}
