using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMAnager : MonoBehaviour
{
    //敵の数を数える変数
    public GameObject[] enemy;

    //パネルを登録する
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        //パネルを隠す
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //シーンに存在しているEnemyタグを持つオブジェクト
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        //1匹もシーンにいなくなると
        if(enemy.Length==0)
        {
            //パネルを表示
            panel.SetActive(true);
        }
    }
}
