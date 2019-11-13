using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StudentViewController : MonoBehaviour
{
    public TextMeshProUGUI sName;
    public Toggle presence;

    public void SetText(string text)
    {
        sName.text = text;
    }



}
