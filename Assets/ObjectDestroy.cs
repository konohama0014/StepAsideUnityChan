using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDestroy : MonoBehaviour
{
    //���b�X���U�ۑ�

    
    //Unity���������p
    private GameObject unityChan;

    // Start is called before the first frame update
    void Start()
    {
        unityChan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        // �\������Ȃ��Ȃ������̏���
        if (unityChan.transform.position.z >= (this.transform.position.z + 10f ) )
        {
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// ��������̓J�����O���擾����p�^�[���@isVisible
    /// </summary>
    /*
    //�`�悷����̂̓��ꕨ
    Renderer targetRenderer;

    //���ł��J�����ɓ�������
    private bool cameraFirstIn = false;


    void Start()
    {
        targetRenderer = GetComponent<Renderer>();
    }  
    
    void Update()
    {
        if (targetRenderer.isVisible)
        {
            // �\������Ă���true�ꍇ�̏���
            cameraFirstIn = true;
        }
        else
        {
            // �\������Ă��Ȃ��ꍇ�̏���
            if(cameraFirstIn == true)
            {
                Destroy(this.gameObject);
            }
        }
    }*/

    /// <summary>
    /// ��������̓J�����O���擾����p�^�[���@OnBecameInvisible
    /// </summary>


    /*void OnBecameInvisible()
    {
        // �\������Ȃ��Ȃ������̏���
        Destroy(this.gameObject);
    }*/




}
