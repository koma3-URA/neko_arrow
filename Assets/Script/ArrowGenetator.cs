using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenetator : MonoBehaviour
{
    [SerializeField] private GameObject arrowPrefab; //���������̃v���n�u

    private float generateInterval = 0.6f; //�����Ԋu
    private float time = 0; //�������Ă���̌o�ߎ���

    // Update is called once per frame
    void Update()
    {
        //�O��̃t���[������̌o�ߎ��Ԃ̘a�𐔂��Ă���
        time += Time.deltaTime;

        //�������Ă���generateInterval���̎��Ԃ��x��������
        if(time > generateInterval)
        {
            //�o�ߎ��Ԃ����Z�b�g����
            time = 0;

            //-10����10�܂ł̊ԂŃ����_���Ȓl���擾����
            float x = Random.Range(-10f, 10f);

            //�����_���Ȉʒu�ɖ�𐶐�����
            Instantiate(arrowPrefab, new Vector2(x, 5.5f), Quaternion.identity);
        }
    }
}
