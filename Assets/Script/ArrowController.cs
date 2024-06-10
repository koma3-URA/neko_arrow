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
        //フレームごとに等速で移動させる
        // transform.position += Vector3.down * fallSpeed;
        transform.Translate(Vector3.down*fallSpeed*Time.deltaTime, Space.World);
        angle += RotateSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, 0, angle);

        //画面買いに出たらオブジェクトを破壊
        if (transform.position.y < -5.0f)
        {
            //Destroyは()内のオブジェクトを破壊する
            Destroy(gameObject);
        }
    }
}
