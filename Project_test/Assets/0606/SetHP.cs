using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    public TextMeshProUGUI Txt_HP;
    public TextMeshProUGUI Txt_text;
    public Image Img_HPbar;

    public int maxHP;
    float nowHP;

    public int Damage;
    public int HealPoint;

    private void Awake()
    {
        nowHP = maxHP;
        Initialize();
    }
    public void OnClickDamage()
    {
        nowHP -= Damage;
        if (nowHP < 0)
        {
            nowHP = 0;
        }

        Txt_text.text = $"{Damage}데미지를 받았다.";
        RefreshUI();
    }

    public void OnClickHeal()
    {
        nowHP += HealPoint;
        if (nowHP > maxHP)
        {
            nowHP = maxHP;
        }

        RefreshUI();
    }


    void Initialize()
    {
        RefreshUI();
    }
    void RefreshUI()
    {
        Img_HPbar.fillAmount = nowHP / maxHP;
        Txt_HP.text = $"{nowHP}/{maxHP}";
    }

}
