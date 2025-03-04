using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected int MaxHP;     // �ő�̗�
    [SerializeField] protected int HP;        // �̗�
    [SerializeField] protected int Attack;    // �U����
    [SerializeField] protected int MoveSpeed; // �ړ����x

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //�����������������������������������������������������������
    //�L�����N�^�[�X�e�[�^�X�̍ő�HP��ݒ肷��֐�
    //�����F������ int�^ maxHP
    //�߂�l�F�Ȃ�
    //�����������������������������������������������������������
    public void SetMaxHP(int maxHP)
    {
        HP = maxHP;
    }

    //�����������������������������������������������������������
    //�L�����N�^�[�X�e�[�^�X�̍ő�HP���擾����֐�
    //�����F�Ȃ�
    //�߂�l�Fint�^
    //�����������������������������������������������������������
    public int GetMaxHP()
    {
        return MaxHP;
    }

    //�����������������������������������������������������������
    //�L�����N�^�[�X�e�[�^�X��HP��ݒ肷��֐�
    //�����F������ int�^ hp
    //�߂�l�F�Ȃ�
    //�����������������������������������������������������������
    public void SetHP(int hp)
    {
        HP = hp;
    }

    //�����������������������������������������������������������
    //�L�����N�^�[�X�e�[�^�X��HP���擾����֐�
    //�����F�Ȃ�
    //�߂�l�Fint�^
    //�����������������������������������������������������������
    public int GetHP()
    {
        return HP;
    }

    //�����������������������������������������������������������
    //�L�����N�^�[�X�e�[�^�X�̍U���͂�ݒ肷��֐�
    //�����F������ int�^ attack
    //�߂�l�F�Ȃ�
    //�����������������������������������������������������������
    public void SetAttack(int attack)
    {
        Attack = attack;
    }

    //�����������������������������������������������������������
    //�L�����N�^�[�X�e�[�^�X�̍U���͂��擾����֐�
    //�����F�Ȃ�
    //�߂�l�Fint�^
    //�����������������������������������������������������������
    public int GetAttack()
    {
        return Attack;
    }

    //�����������������������������������������������������������
    //�L�����N�^�[�̈ړ����x��ݒ肷��֐�
    //�����F������ int�^ moveSpeed
    //�߂�l�F�Ȃ�
    //�����������������������������������������������������������
    public void SetMoveSpeed(int moveSpeed)
    {
        MoveSpeed = moveSpeed;
    }

    //�����������������������������������������������������������
    //�L�����N�^�[�̈ړ����x���擾����֐�
    //�����F�Ȃ�
    //�߂�l�Fint�^
    //�����������������������������������������������������������
    public int GetMoveSpeed()
    {
        return MoveSpeed;
    }
}
