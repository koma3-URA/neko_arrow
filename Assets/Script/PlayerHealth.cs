using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int hp;
    public AudioClip DamageSE;
    AudioSource audioSource;
    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        //�Փ˂����I�u�W�F�N�g����ł���Ȃ�
        if (other.gameObject.CompareTag("Arrow"))
        {
            audioSource.PlayOneShot(DamageSE);
            //HP�����炷
            hp--;

            //����폜����
            Destroy(other.gameObject);
        }
    }
}

