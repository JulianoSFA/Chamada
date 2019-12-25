using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowViewValues : MonoBehaviour
{
    private Student student;

    public TextMeshProUGUI sName;
    public TextMeshProUGUI instrument;
    public TextMeshProUGUI abscenses;

    public Student Student
    {
        set
        {
            student = value;
        }
    }

    private void Start()
    {
        StartCoroutine(StartView());
    }

    IEnumerator StartView()
    {
        sName.text = student.sName;
        instrument.text = student.instrument;
        abscenses.text = student.Absences().ToString();
        yield return null;
    }
}
