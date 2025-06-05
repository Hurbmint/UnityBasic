using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JHJ : MonoBehaviour
{
    string name = "정호진";
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
        Debug.Log($"제 이름은 {name}이고, 나이는 {age}살 입니다.\n 키는 {height}cm이고, 몸무게는 {weight}kg입니다. mbti는 {mbti}입니다.\n");
        if (male)
        {
            Debug.Log("성별은 남성입니다.");
        }
        Debug.Log($"{hometown}에서 태어나 {education}를 졸업했습니다.\n{hobby} 등의 취미를 가지고 있으며, 훌륭한 {dream}가 되는 것이 목표입니다.");

    }
}