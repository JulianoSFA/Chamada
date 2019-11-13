using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowStudent : MonoBehaviour
{
    public TextMeshProUGUI sName;
    public TextMeshProUGUI sInstrument;

    public void SetNames(string name, string ins)
    {
        sName.text = name;
        sInstrument.text = ins;
    }
}
