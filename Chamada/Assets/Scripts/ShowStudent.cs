using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowStudent : MonoBehaviour
{
    public TextMeshProUGUI sName;
    public TextMeshProUGUI instrument;
    public Toggle toggle;

    public Student student;

    void Start()
    {
        sName.text = student.sName;
        instrument.text = student.instrument;
    }
}
