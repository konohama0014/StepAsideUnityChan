using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefab������
    public GameObject carPrefab;

    //coinPrefab������
    public GameObject coinPrefab;

    //conePrefab������
    public GameObject conePrefab;

    //�X�^�[�g�n�_
    private int startPos = 80;

    //�S�[���n�_
    private int goalPos = 360;

    //�A�C�e�����o��X�����͈̔�
    private float posRange = 3.4f;

    //�y���W�ۑ�zUnity���������悤
    public GameObject unityChan;

    //�y���W�ۑ�zUnity�����̑O��
    private int frontDistance = 60;

    //�y���W�ۑ�z�����񐔂̃J�E���g�p
    private int generateCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Unity����������
        unityChan = GameObject.Find("unitychan");

        /*
        //���̋������ƂɃA�C�e���𐶐�
        for (int i = startPos; i <goalPos; i+=15)
        {
            //�ǂ̃A�C�e�����o���̂��������_���ɐݒ�
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //�R�[����x�������Ɉ꒼���ɐ���
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {

                //���[�����ƂɃA�C�e���𐶐�
                for (int j = -1; j<=1; j++)
                {
                    //�A�C�e���̎�ނ����߂�
                    int item = Random.Range(1, 11);

                    //�A�C�e����u��Z���W�̃I�t�Z�b�g�������_���ɐݒ�
                    int offsetZ = Random.Range(-5, 6);

                    //60%�R�C���z�u�F30%�Ԕz�u:10%�����Ȃ�
                    if (1 <= item && item <= 6)
                    {
                        //�R�C���𐶐�
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //�Ԃ𐶐�
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
        //�X�^�[�g����S�[���܂ł̊Ԃł�����������
        if(goalPos > (startPos + (15 * generateCounter)))
        {
            //Unity������O60m�ɃA�C�e���𐶐�����A������15m�Ԋu��
            if ((unityChan.transform.position.z + 60f) >= (startPos + (15 * generateCounter)))
            {
                //�ǂ̃A�C�e�����o���̂��������_���ɐݒ�
                int num = Random.Range(1, 11);
                if (num <= 2)
                {
                    //�R�[����x�������Ɉ꒼���ɐ���
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        GameObject cone = Instantiate(conePrefab);
                        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, (startPos + (15 * generateCounter)));
                    }
                }
                else
                {

                    //���[�����ƂɃA�C�e���𐶐�
                    for (int j = -1; j <= 1; j++)
                    {
                        //�A�C�e���̎�ނ����߂�
                        int item = Random.Range(1, 11);

                        //�A�C�e����u��Z���W�̃I�t�Z�b�g�������_���ɐݒ�
                        int offsetZ = Random.Range(-5, 6);

                        //60%�R�C���z�u�F30%�Ԕz�u:10%�����Ȃ�
                        if (1 <= item && item <= 6)
                        {
                            //�R�C���𐶐�
                            GameObject coin = Instantiate(coinPrefab);
                            coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, (startPos + (15 * generateCounter)) + offsetZ);
                        }
                        else if (7 <= item && item <= 9)
                        {
                            //�Ԃ𐶐�
                            GameObject car = Instantiate(carPrefab);
                            car.transform.position = new Vector3(posRange * j, car.transform.position.y, (startPos + (15 * generateCounter)) + offsetZ);
                        }
                    }
                }
                //�W�F�l���[�V�����J�E���^�[�{�P
                ++generateCounter;
            }
        }
    }
}
