using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    float rotSpeed = 0;                      //���� ȸ�� �ӵ� 



    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.rotSpeed = 10000;
        }

        transform.Rotate(0, this.rotSpeed * Time.deltaTime, 0);           //transform�� ĳ������ ��ġ ���۳�Ʈ
                                                                          //Rotate �Լ��� ȸ���� �����ִ� �Լ�
        rotSpeed *= 0.99f;                                                //�����Ӹ��� 1% �� �ӵ� ����
    }
}
