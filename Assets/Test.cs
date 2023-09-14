using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //配列を初期化する
        int[] array = { 80, 30, 70, 100, 20 };

        //要素を全て表示
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //要素を逆順で表示する
        for(int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}