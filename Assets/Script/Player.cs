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

    //�����������������������������������������������������������
    //�v���C���[�̈ړ�����
    //�����@�F�Ȃ�
    //�߂�l�F�Ȃ�
    //�����������������������������������������������������������
    private void Move()
    {
        // A�L�[�ō��ړ�
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-MoveSpeed, 0.0f, 0.0f, Space.World);
        }
        // D�L�[�ŉE�ړ�
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(MoveSpeed, 0.0f, 0.0f, Space.World);
        }
    }

    //�����������������������������������������������������������
    //�v���C���[�̃W�����v����
    //�����@�F�Ȃ�
    //�߂�l�F�Ȃ�
    //�����������������������������������������������������������
    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
        }
    }
}
