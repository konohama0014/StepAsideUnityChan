using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;

    //coinPrefabを入れる
    public GameObject coinPrefab;

    //conePrefabを入れる
    public GameObject conePrefab;

    //スタート地点
    private int startPos = 80;

    //ゴール地点
    private int goalPos = 360;

    //アイテムを出すX方向の範囲
    private float posRange = 3.4f;

    //【発展課題】Unityちゃん入れるよう
    public GameObject unityChan;

    //【発展課題】Unityちゃんの前方
    private int frontDistance = 60;

    //【発展課題】生成回数のカウント用
    private int generateCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんを入れる
        unityChan = GameObject.Find("unitychan");

        /*
        //一定の距離ごとにアイテムを生成
        for (int i = startPos; i <goalPos; i+=15)
        {
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {

                //レーンごとにアイテムを生成
                for (int j = -1; j<=1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);

                    //アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);

                    //60%コイン配置：30%車配置:10%何もなし
                    if (1 <= item && item <= 6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                        

                }
            }
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        //スタートからゴールまでの間でだけ処理する
        if(goalPos > (startPos + (15 * generateCounter)))
        {
            //Unityちゃん手前60mにアイテムを生成する、だたし15m間隔で
            if ((unityChan.transform.position.z + 60f) >= (startPos + (15 * generateCounter)))
            {
                //どのアイテムを出すのかをランダムに設定
                int num = Random.Range(1, 11);
                if (num <= 2)
                {
                    //コーンをx軸方向に一直線に生成
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        GameObject cone = Instantiate(conePrefab);
                        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, (startPos + (15 * generateCounter)));
                    }
                }
                else
                {

                    //レーンごとにアイテムを生成
                    for (int j = -1; j <= 1; j++)
                    {
                        //アイテムの種類を決める
                        int item = Random.Range(1, 11);

                        //アイテムを置くZ座標のオフセットをランダムに設定
                        int offsetZ = Random.Range(-5, 6);

                        //60%コイン配置：30%車配置:10%何もなし
                        if (1 <= item && item <= 6)
                        {
                            //コインを生成
                            GameObject coin = Instantiate(coinPrefab);
                            coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, (startPos + (15 * generateCounter)) + offsetZ);
                        }
                        else if (7 <= item && item <= 9)
                        {
                            //車を生成
                            GameObject car = Instantiate(carPrefab);
                            car.transform.position = new Vector3(posRange * j, car.transform.position.y, (startPos + (15 * generateCounter)) + offsetZ);
                        }
                    }
                }
                //ジェネレーションカウンター＋１
                ++generateCounter;
            }
        }
    }
}
