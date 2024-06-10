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
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        //衝突したオブジェクトが矢であるなら
        if (other.gameObject.CompareTag("Arrow"))
        {
            audioSource.PlayOneShot(DamageSE);
            //HPを減らす
            hp--;

            //矢を削除する
            Destroy(other.gameObject);
        }
    }
}

