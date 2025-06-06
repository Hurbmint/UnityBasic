using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetTextBox : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text;
    [SerializeField] TMP_InputField Input_Text;

    public void OnClickButton()
    {
        Txt_Text.text = Input_Text.text;
    }

}
