using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDestroy : MonoBehaviour
{
    //レッスン６課題

    
    //Unityちゃん入れる用
    private GameObject unityChan;

    // Start is called before the first frame update
    void Start()
    {
        unityChan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        // 表示されなくなった時の処理
        if (unityChan.transform.position.z >= (this.transform.position.z + 10f ) )
        {
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// ここからはカメラ外を取得するパターン　isVisible
    /// </summary>
    /*
    //描画するものの入れ物
    Renderer targetRenderer;

    //一回でもカメラに入ったら
    private bool cameraFirstIn = false;


    void Start()
    {
        targetRenderer = GetComponent<Renderer>();
    }  
    
    void Update()
    {
        if (targetRenderer.isVisible)
        {
            // 表示されているtrue場合の処理
            cameraFirstIn = true;
        }
        else
        {
            // 表示されていない場合の処理
            if(cameraFirstIn == true)
            {
                Destroy(this.gameObject);
            }
        }
    }*/

    /// <summary>
    /// ここからはカメラ外を取得するパターン　OnBecameInvisible
    /// </summary>


    /*void OnBecameInvisible()
    {
        // 表示されなくなった時の処理
        Destroy(this.gameObject);
    }*/




}
