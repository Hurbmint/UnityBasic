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

    string[] studentA = { "히나", "아루", "유우카"};
    string[] studentB = { "나기사", "세이아", "미카" };
    string[] studentC = { "아코", "이오리", "치나츠" };
    List<string> studentListSSR = new List<string>();
    List<string> studentListSR = new List<string>();
    List<string> studentListR = new List<string>();

    void Start()
    {
        for (int i = 0; i < studentA.Length; i++)   //SSR 리스트
        {
            studentListSSR.Add(studentA[i]);        
        }

        for (int i = 0; i < studentListSSR.Count; i++)
        {
            Debug.Log($"SSR 픽업 풀에 {studentListSSR[i]} 추가");
        }



        for (int i = 0; i < studentB.Length; i++)   //SR 리스트
        {
            studentListSR.Add(studentB[i]);
        }

        for (int i = 0; i < studentListSR.Count; i++)
        {
            Debug.Log($"SR 픽업 풀에 {studentListSR[i]} 추가");
        }

        for (int i = 0; i < studentC.Length; i++)   //R 리스트
        {
            studentListR.Add(studentC[i]);
        }

        for (int i = 0; i < studentListR.Count; i++)
        {
            Debug.Log($"R 픽업 풀에 {studentListR[i]} 추가");
        }
    }

    
    public void Blackcow()
        {
            diamond += 12000;
            Debug.Log($"청휘석 12000개가 충전되었습니다.");

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
                //Debug.Log($"랜덤한 값은 {randomvalue}입니다.");

                if (count >= 200)
                {
                    Debug.Log("확정 SSR 등급 뽑기");
                    count = 0;
                }
                else if (randomvalue <= 10)
                {
                    int SSR = Random.Range(0, studentListSSR.Count);
                    Debug.Log($"'{studentListSSR[SSR]}'을 뽑았다.");
                }
                else if (randomvalue <= 30)
                {
                    int SR = Random.Range(0, studentListSR.Count);
                    Debug.Log($"'{studentListSR[SR]}'을 뽑았다.");
                }
                else
                {
                    int R = Random.Range(0, studentListR.Count);
                    Debug.Log($"'{studentListR[R]}'을 뽑았다.");
                }

                count++;
            }

            diamond -= 1200;
            RefreshUI();
        }
        else
        {
            Debug.Log("청휘석이 부족합니다.");
        }
    }





    void RefreshUI()
    {
        Txt_diamond.text = $"{diamond}";
    }

}

