using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int enemyHp;
    // Start is called before the first frame update
    public void Damage()
    {
        //Enemyの体力を減らす
        enemyHp = enemyHp - 1;
    }
    void Start()
    {
        enemyHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHp<=0)
        {
            Destroy(this.gameObject);
        }
    }
}
