using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int count;
    private void Awake()
    {
        count = 0;
    }

    void Start()
    {


    }

    // Start is called before the first frame update
    public void Gacha()
    {
        int number = 0;
        while (number<10)
        {
            
            number++;
        }

        for (int i = 0; i < 11; i++)
        {

            int randomvalue = Random.Range(0, 100);
            Debug.Log($"������ ���� {randomvalue}�Դϴ�.");

            if (count >= 8)
            {
                Debug.Log("Ȯ������ '��û'�� �̾Ҵ�.");
                count = 0;
            }
            else if (randomvalue <= 10)
            {
                Debug.Log("'��û'�� �̾Ҵ�.");
            }
            else if (randomvalue <= 30)
            {
                Debug.Log("'��'�� �̾Ҵ�.");
            }
            else
            {
                Debug.Log("'ġġ'�� �̾Ҵ�.");
            }

            count++;
        }
    }







    /*
        public void GachaSwitch()
        {
            // 
            int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

            int selectNumbe = 0;

            switch (selectNumbe) //0
            {
                case 0:
                    // ���� �Ӹ� ĳ���Ͱ� ���´�
                    {
                        if (randomValue <= 10) // 1 ~ 10 -> 10%
                        {
                            // �Ⱦ� ĳ�� : �̹� �̱⿡ Ȯ���� ����  �����Ǵ� ĳ����
                            // �������� Ư�� ĳ���͸� ��ǥ�ϰ� �̰� ����� �ý���
                            Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                        }
                        else if (randomValue <= 30) // 11 ~ 30
                        {
                            Debug.Log("'��'�� �̾Ҵ�!");
                        }
                        else
                        {
                            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                        }
                    }
                    break;

                case 1:
                    // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                    {
                        if (randomValue <= 10) // 1 ~ 10 -> 10%
                        {
                            Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                        }
                        else if (randomValue <= 30) // 11 ~ 30
                        {
                            Debug.Log("'��'�� �̾Ҵ�!");
                        }
                        else
                        {
                            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                        }
                    }
                    break;

                case 2:
                    // ��ȫ �Ӹ� ĳ���Ͱ� ���´�
                    {
                        if (randomValue <= 10) // 1 ~ 10 -> 10%
                        {
                            Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
                        }
                        else if (randomValue <= 30) // 11 ~ 30
                        {
                            Debug.Log("'��'�� �̾Ҵ�!");
                        }
                        else
                        {
                            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                        }
                    }
                    break;

                default:
                    // �Ķ� �Ӹ� ���� ĳ���Ͱ� ���´�.
                    {
                        if (randomValue <= 10) // 1 ~ 10 -> 10%
                        {
                            Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
                        }
                        else if (randomValue <= 30) // 11 ~ 30
                        {
                            Debug.Log("'��'�� �̾Ҵ�!");
                        }
                        else
                        {
                            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                        }
                    }
                    break;
            }
        }*/
}




