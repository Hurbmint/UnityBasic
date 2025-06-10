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

        // 페이즈 1

        int j = 0;

        for (int i = 0; i < 5; i++)
        {
            j++;
            for (int k = 0; k < j; k++)
            {
                star += "★";
            }
            star += "\n";       
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2 : 모든 줄이 별과 공백의 5개 조합

        for (int i = 0; i < 5; i++)         //공백을 기준으로, 나머지는 별
        {
            for (int k = 0; k < 5; k++)
            {
                if (k < i)
                {
                    star += "　";
                }
                else
                {
                    star += "★";
                }
            }
            star += "\n";       //1행 작성 완료 후 열 바꾸기, 전체 5열
        }

        Debug.Log(star);        //최종 결과




    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3 - 페이즈2보다 1에 가까움 = 별을 기준으로, 나머지는 공백

        for (int i = 0; i < 9; i++)
        {
            if (i<5)                            //처음 5줄
            {
                for (int k = 0; k < 5; k++)     
                {
                    if (k < i + 1)
                    {
                        star += "★";
                    }
                    else
                    {
                        star += "　";
                    }
                }
            }
            else
            {                                   //나머지 4줄
                for (int k = 0; k < 5; k++)     
                {
                    if (k < 9 - i)              //별을 중심으로, 상하 반전(점차 감소)
                    {
                        star += "★";
                    }
                    else
                    {
                        star += "　";
                    }
                }
            }


            star += "\n";       //1행 작성 완료 후 열 바꾸기, 전체 9열
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4

        for (int i = 0; i < 9; i++)
        {
            if (i < 5)                            //처음 5줄
            {
                for (int k = 0; k < 5; k++)     //점차 감소 후 증가
                {
                    if (k < 4 - i)              //i=4(5열)에서 공백0, 별5
                    {
                        star += "　";
                    }
                    else
                    {
                        star += "★";
                    }
                }
            }
            else                                //나머지 4줄
            {
                for (int k = 0; k < 5; k++)     
                {
                    if (k < i - 4)              //i=8(9열)에서 공백4, 별1
                    {
                        star += "　";
                    }
                    else
                    {
                        star += "★";
                    }
                }
            }


            star += "\n";       //1행 작성 완료 후 열 바꾸기, 전체 9열
        }

        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5

        for (int i = 0; i < 9; i++)
        {
            if (i < 5)                            //처음 5줄
            {
                for (int k = 0; k < 9; k++)     //점차 감소 후 증가
                {
                    if (k < 4 - i)              //1열(i=0) 기준 0,1,2,3행에 공백, 점차 범위 감소
                    {
                        star += "　";
                    }
                    else if (k > i + 4)         //1열 기준 5,6,7,8행에 공백
                    {
                        star += "　";
                    }
                    else                        //나머지 4행에 별
                    {
                        star += "★";
                    }
                }
            }
            else                                //나머지 4줄
            {
                for (int k = 0; k < 9; k++)
                {
                    if (k < i - 4)              //
                    {
                        star += "　";
                    }
                    else if (k > 12 - i)              //
                    {
                        star += "　";
                    }
                    else
                    {
                        star += "★";
                    }
                }
            }


            star += "\n";       //1행 작성 완료 후 열 바꾸기, 전체 9열
        }

        Debug.Log(star);
    }
}





