using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60; //fpsを６０に固定
    }

    // Update is called once per frame
    void Update()
    {
        //左矢印キーが押されたら
        if(Input.GetKeyDown(KeyCode.LeftArrow)) //キーが押されたことを検知するGetKeyDownメソッドを使う。
        {
            transform.Translate(-3, 0, 0); //左に「-3」動かす
        }

        //右矢印キーが押されたら
        if (Input.GetKeyDown(KeyCode.RightArrow)) //キーが押されたことを検知するGetKeyDownメソッドを使う。
        {
            transform.Translate(3, 0, 0); //右に「-3」動かす
        }
    }
}
