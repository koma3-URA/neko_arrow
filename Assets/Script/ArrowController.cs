using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private float angle;
    public float RotateSpeed = 10f;
    public float fallSpeed;
    // Update is called once per frame
    void Update()
    {
        //�t���[�����Ƃɓ����ňړ�������
        // transform.position += Vector3.down * fallSpeed;
        transform.Translate(Vector3.down*fallSpeed*Time.deltaTime, Space.World);
        angle += RotateSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, 0, angle);

        //��ʔ����ɏo����I�u�W�F�N�g��j��
        if (transform.position.y < -5.0f)
        {
            //Destroy��()���̃I�u�W�F�N�g��j�󂷂�
            Destroy(gameObject);
        }
    }
}
