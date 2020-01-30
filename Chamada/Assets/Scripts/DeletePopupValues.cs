using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeletePopupValues : MonoBehaviour
{
    public Student student;
    public TextMeshProUGUI warningName;

    private void Start()
    {
        warningName.text = "Você tem certeza que deseja apagar " + student.ShortName();
    }

    public void DisableStudent()
    {
        student.SetActivity(false);
    }
}
