using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60; //fps���U�O�ɌŒ�
    }

    // Update is called once per frame
    void Update()
    {
        //�����L�[�������ꂽ��
        if(Input.GetKeyDown(KeyCode.LeftArrow)) //�L�[�������ꂽ���Ƃ����m����GetKeyDown���\�b�h���g���B
        {
            transform.Translate(-3, 0, 0); //���Ɂu-3�v������
        }

        //�E���L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.RightArrow)) //�L�[�������ꂽ���Ƃ����m����GetKeyDown���\�b�h���g���B
        {
            transform.Translate(3, 0, 0); //�E�Ɂu-3�v������
        }
    }
}
