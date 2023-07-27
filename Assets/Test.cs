using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] array = new int[5];

        //配列の各要素に値を値を代入する
        array[0] = 10;
        array[1] = 90;
        array[2] = 30;
        array[3] = 20;
        array[4] = 40;

        //配列の要素全てを表示する
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}