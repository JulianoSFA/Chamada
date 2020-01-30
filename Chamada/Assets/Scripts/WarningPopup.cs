using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WarningPopup : MonoBehaviour
{
    public TextMeshProUGUI sName;
    public TextMeshProUGUI absences;

    public Animator animator;

    public void WarningSetup(Student student)
    {
        sName.text = student.ShortName();
        absences.text = "Faltas: " + student.AbsencesInARow().ToString();
    }

    private void Start()
    {
        StartCoroutine(DestroyPopup());
    }

    IEnumerator DestroyPopup()
    {
        yield return new WaitForSecondsRealtime(5f);
        animator.SetTrigger("CloseWarning");
        yield return new WaitForSecondsRealtime(0.4f);
        Destroy(this.gameObject);
    }
}
