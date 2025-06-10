using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starlight : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        // ������ 1

        int j = 0;

        for (int i = 0; i < 5; i++)
        {
            j++;
            for (int k = 0; k < j; k++)
            {
                star += "��";
            }
            star += "\n";       
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2 : ��� ���� ���� ������ 5�� ����

        for (int i = 0; i < 5; i++)         //������ ��������, �������� ��
        {
            for (int k = 0; k < 5; k++)
            {
                if (k < i)
                {
                    star += "��";
                }
                else
                {
                    star += "��";
                }
            }
            star += "\n";       //1�� �ۼ� �Ϸ� �� �� �ٲٱ�, ��ü 5��
        }

        Debug.Log(star);        //���� ���




    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3 - ������2���� 1�� ����� = ���� ��������, �������� ����

        for (int i = 0; i < 9; i++)
        {
            if (i<5)                            //ó�� 5��
            {
                for (int k = 0; k < 5; k++)     
                {
                    if (k < i + 1)
                    {
                        star += "��";
                    }
                    else
                    {
                        star += "��";
                    }
                }
            }
            else
            {                                   //������ 4��
                for (int k = 0; k < 5; k++)     
                {
                    if (k < 9 - i)              //���� �߽�����, ���� ����(���� ����)
                    {
                        star += "��";
                    }
                    else
                    {
                        star += "��";
                    }
                }
            }


            star += "\n";       //1�� �ۼ� �Ϸ� �� �� �ٲٱ�, ��ü 9��
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4

        for (int i = 0; i < 9; i++)
        {
            if (i < 5)                            //ó�� 5��
            {
                for (int k = 0; k < 5; k++)     //���� ���� �� ����
                {
                    if (k < 4 - i)              //i=4(5��)���� ����0, ��5
                    {
                        star += "��";
                    }
                    else
                    {
                        star += "��";
                    }
                }
            }
            else                                //������ 4��
            {
                for (int k = 0; k < 5; k++)     
                {
                    if (k < i - 4)              //i=8(9��)���� ����4, ��1
                    {
                        star += "��";
                    }
                    else
                    {
                        star += "��";
                    }
                }
            }


            star += "\n";       //1�� �ۼ� �Ϸ� �� �� �ٲٱ�, ��ü 9��
        }

        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5

        for (int i = 0; i < 9; i++)
        {
            if (i < 5)                            //ó�� 5��
            {
                for (int k = 0; k < 9; k++)     //���� ���� �� ����
                {
                    if (k < 4 - i)              //1��(i=0) ���� 0,1,2,3�࿡ ����, ���� ���� ����
                    {
                        star += "��";
                    }
                    else if (k > i + 4)         //1�� ���� 5,6,7,8�࿡ ����
                    {
                        star += "��";
                    }
                    else                        //������ 4�࿡ ��
                    {
                        star += "��";
                    }
                }
            }
            else                                //������ 4��
            {
                for (int k = 0; k < 9; k++)
                {
                    if (k < i - 4)              //
                    {
                        star += "��";
                    }
                    else if (k > 12 - i)              //
                    {
                        star += "��";
                    }
                    else
                    {
                        star += "��";
                    }
                }
            }


            star += "\n";       //1�� �ۼ� �Ϸ� �� �� �ٲٱ�, ��ü 9��
        }

        Debug.Log(star);
    }
}





