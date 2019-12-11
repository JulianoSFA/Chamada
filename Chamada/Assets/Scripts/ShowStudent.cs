using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ShowStudent : MonoBehaviour
{
    public TextMeshProUGUI sName;
    public TextMeshProUGUI sInstrument;
    public Toggle presence;

    public Database db;

    public void SetNames(string name, string ins)
    {
        sName.text = name;
        sInstrument.text = ins;
        db = FindObjectOfType<Database>();
    }


    public void SetAttendance()
    {
        foreach (Student s in db.studentList)
        {
            if (s.sName == sName.ToString())
            {
                Attendance todayEntry = new Attendance();
                DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                todayEntry.NewAttendance(today, presence);
                s.attendance.Add(todayEntry);
                Debug.Log(string.Format("O aluno {0} teve presença {1} no dia {3}", s.sName, presence, today));
            }
            else
                return;
        }
    }
}
