using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFowardShot : MonoBehaviour
{
    //プレイヤー
    private GameObject player;

    //弾のゲームオブジェクトを入れる
    public GameObject bullet;

    //打ち出す間隔を決める
    public float time = 1;

    //最初に打ち出すまでの時間を決める
    public float delayTime = 1;

    //現在の時間
    float nowtime = 0;
    // Start is called before the first frame update
    void Start()
    {
        //タイマーを初期化
        nowtime = delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        //もしプレイヤーの情報が入っていなければ
        if(player==null)
        {
            //プロジェクトのPLAYERをさがして情報を取得
            player = GameObject.FindGameObjectWithTag("Player");
        }

        //タイマーを減らす
        nowtime-=Time.deltaTime;

        //もしタイマーが０以下になったら
        if(nowtime<=0)
        {
            //弾を生成
            CreateShotObject(-transform.localEulerAngles.y);

            //タイマーを初期化
            nowtime = time;
        }
    }

    private void CreateShotObject(float axis)
    {
        //ベクトル取得
        var direction = player.transform.position- transform.position;

        //ベクトルyを初期化
        direction.y = 0;

        //向きを取得する
        var lookRotation=Quaternion.LookRotation(direction,Vector3.up);

        //弾を生成する
        GameObject bulletClone=Instantiate(bullet,transform.position,Quaternion.identity);

        //EnemyBulletのゲットコンポーネントを変数として保存
        var bulletObject =bulletClone.GetComponent<EnemyBullet>();

        //弾を打ち出したオブジェクトの情報を渡す
        bulletObject.SetCharacterObject(gameObject);

        //弾を撃ちだす角度を変更する
        bulletObject.SetForwardAxis(lookRotation * Quaternion.AngleAxis(axis, Vector3.up));
    }
}

