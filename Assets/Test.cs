using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53; //マジックポイント

    //魔法攻撃関数
    public void Magic(int loss)
    {
        if (mp >= loss)
        {
            mp -= loss;
            Debug.Log("魔法攻撃をした。残りMPは"+ mp +"。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない");
        }
    }

}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss Mboss = new Boss();

        //Magic関数を10回使う
        for (int i = 0; i < 10; i++)
        {
            Mboss.Magic(5);
        }

        //さらにMagic関数を呼び出す
        Mboss.Magic(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}