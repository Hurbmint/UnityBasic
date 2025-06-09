using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Archive : MonoBehaviour
{
    public TextMeshProUGUI Txt_diamond;

    int count = 0;
    int diamond = 24000;

    string[] studentA = { "����", "�Ʒ�", "����ī"};
    string[] studentB = { "�����", "���̾�", "��ī" };
    string[] studentC = { "����", "�̿���", "ġ����" };
    List<string> studentListSSR = new List<string>();
    List<string> studentListSR = new List<string>();
    List<string> studentListR = new List<string>();

    void Start()
    {
        for (int i = 0; i < studentA.Length; i++)   //SSR ����Ʈ
        {
            studentListSSR.Add(studentA[i]);        
        }

        for (int i = 0; i < studentListSSR.Count; i++)
        {
            Debug.Log($"SSR �Ⱦ� Ǯ�� {studentListSSR[i]} �߰�");
        }



        for (int i = 0; i < studentB.Length; i++)   //SR ����Ʈ
        {
            studentListSR.Add(studentB[i]);
        }

        for (int i = 0; i < studentListSR.Count; i++)
        {
            Debug.Log($"SR �Ⱦ� Ǯ�� {studentListSR[i]} �߰�");
        }

        for (int i = 0; i < studentC.Length; i++)   //R ����Ʈ
        {
            studentListR.Add(studentC[i]);
        }

        for (int i = 0; i < studentListR.Count; i++)
        {
            Debug.Log($"R �Ⱦ� Ǯ�� {studentListR[i]} �߰�");
        }
    }

    
    public void Blackcow()
        {
            diamond += 12000;
            Debug.Log($"û�ּ� 12000���� �����Ǿ����ϴ�.");

            RefreshUI();
        }

    // Update is called once per frame
    public void Gacha_10()
    {
        if (diamond >= 1200)
        {
            for (int i = 0; i < 10; i++)
            {

                int randomvalue = Random.Range(0, 100);
                //Debug.Log($"������ ���� {randomvalue}�Դϴ�.");

                if (count >= 200)
                {
                    Debug.Log("Ȯ�� SSR ��� �̱�");
                    count = 0;
                }
                else if (randomvalue <= 10)
                {
                    int SSR = Random.Range(0, studentListSSR.Count);
                    Debug.Log($"'{studentListSSR[SSR]}'�� �̾Ҵ�.");
                }
                else if (randomvalue <= 30)
                {
                    int SR = Random.Range(0, studentListSR.Count);
                    Debug.Log($"'{studentListSR[SR]}'�� �̾Ҵ�.");
                }
                else
                {
                    int R = Random.Range(0, studentListR.Count);
                    Debug.Log($"'{studentListR[R]}'�� �̾Ҵ�.");
                }

                count++;
            }

            diamond -= 1200;
            RefreshUI();
        }
        else
        {
            Debug.Log("û�ּ��� �����մϴ�.");
        }
    }





    void RefreshUI()
    {
        Txt_diamond.text = $"{diamond}";
    }

}

