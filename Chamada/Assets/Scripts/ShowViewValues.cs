using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowViewValues : Visual
{
    public TextMeshProUGUI sName;
    public TextMeshProUGUI instrument;
    public TextMeshProUGUI abscenses;

    private void Start()
    {
        StartCoroutine(StartView());
    }

    IEnumerator StartView()
    {
        sName.text = student.ShortName();
        instrument.text = student.instrument;
        abscenses.text = student.Absences().ToString();
        yield return null;
    }
}
