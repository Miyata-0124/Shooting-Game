using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //弾のワールド座標を取得
        Vector3 pos = transform.position;

        //上に飛ぶ
        pos.z += 0.05f;

        //弾の移動
        transform.position=new Vector3(pos.x, pos.y, pos.z);

        //一定距離で消滅
        if(pos.z>=20)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //もし当たったオブジェクトがEnemyだったら
        if(other.gameObject.tag=="Enemy")
        {
            //当たったオブジェクトのEnemyスクリプトを呼び出しDamage関数を実行
            other.GetComponent<Enemy>().Damage();
            Destroy(this.gameObject);
        }
    }
}
