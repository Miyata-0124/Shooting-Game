using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMAnager : MonoBehaviour
{
    //�G�̐��𐔂���ϐ�
    public GameObject[] enemy;

    //�p�l����o�^����
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        //�p�l�����B��
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //�V�[���ɑ��݂��Ă���Enemy�^�O�����I�u�W�F�N�g
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        //1�C���V�[���ɂ��Ȃ��Ȃ��
        if(enemy.Length==0)
        {
            //�p�l����\��
            panel.SetActive(true);
        }
    }
}
