using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class StudentViewController : MonoBehaviour
{
    public TextMeshProUGUI sName;
    public Toggle presence;

    public Database db;

    public void SetText(string text)
    {
        sName.text = text;
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
