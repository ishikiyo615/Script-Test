using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りＭＰは" + this.mp + "。");
        }
        else
        {
            Debug.Log("ＭＰが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start() {

        //以下、最初の課題です。

        Debug.Log("最初の課題");
        int[] array = { 30, 50, 20, 40, 70 };

        //頭から表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //逆から表示
        for (int t = 4; t >= 0; t--)
        {
            Debug.Log(array[t]);
        }

        Debug.Log("発展課題");

        Boss lastboss = new Boss();
        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
