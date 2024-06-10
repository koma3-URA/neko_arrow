using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenetator : MonoBehaviour
{
    [SerializeField] private GameObject arrowPrefab; //生成する矢のプレハブ

    private float generateInterval = 0.6f; //生成間隔
    private float time = 0; //生成してからの経過時間

    // Update is called once per frame
    void Update()
    {
        //前回のフレームからの経過時間の和を数えておく
        time += Time.deltaTime;

        //生成してからgenerateInterval分の時間が警戒したら
        if(time > generateInterval)
        {
            //経過時間をリセットする
            time = 0;

            //-10から10までの間でランダムな値を取得する
            float x = Random.Range(-10f, 10f);

            //ランダムな位置に矢を生成する
            Instantiate(arrowPrefab, new Vector2(x, 5.5f), Quaternion.identity);
        }
    }
}
