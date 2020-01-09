using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowDeleteValues : Visual
{
    public TextMeshProUGUI sName;
    public TextMeshProUGUI instrument;

    private void Start()
    {
        StartCoroutine(StartView());
    }

    IEnumerator StartView()
    {
        sName.text = student.sName;
        instrument.text = student.instrument;
        yield return null;
    }
}
