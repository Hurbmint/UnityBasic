using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JHJ : MonoBehaviour
{
    string name = "��ȣ��";
    int age = 25;
    float height = 169.4f;
    int weight = 51;
    string mbti = "INTJ";
    bool male = true;
    string hometown = "Busan";
    string education = "Pusan National University";
    string hobby = "Game, Music, Novel";
    string dream = "game designer";
    





    void Start()
    {
        Introduction();
        //Introduction(name, age);
    }

    public void Introduction()
    {
        Debug.Log($"�� �̸��� {name}�̰�, ���̴� {age}�� �Դϴ�.\n Ű�� {height}cm�̰�, �����Դ� {weight}kg�Դϴ�. mbti�� {mbti}�Դϴ�.\n");
        if (male)
        {
            Debug.Log("������ �����Դϴ�.");
        }
        Debug.Log($"{hometown}���� �¾ {education}�� �����߽��ϴ�.\n{hobby} ���� ��̸� ������ ������, �Ǹ��� {dream}�� �Ǵ� ���� ��ǥ�Դϴ�.");

    }
}