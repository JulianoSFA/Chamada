
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentEntry : MonoBehaviour
{
    public Database db;
    public GameObject Button;
    public GameObject blankSpace;

    public void SpawnButtons()
    {
        StartCoroutine(SpawnStudentButton());
    }

    IEnumerator SpawnStudentButton()
    {
        if(db.studentList.Count > 0)
        {
            foreach (Student s in db.studentList)
            {
                GameObject InstantiatedButton = Instantiate(Button, this.transform);
                InstantiatedButton.GetComponent<ShowStudent>().student = s;
            }
            blankSpace.SetActive(false);
        }
        else
        {
            blankSpace.SetActive(true);
        }
        yield return new WaitForSeconds(1f);
    }

    public void ComputeAttendance()
    {
        foreach (Transform child in this.gameObject.transform)
        {
            ShowStudent childStudent = child.gameObject.GetComponent<ShowStudent>();
            childStudent.ComputeAttendance();
            foreach (Attendance a in childStudent.student.attendance)
            {
                Debug.Log(a.date + " " + a.showedUp);
            }
        }
        ClearEntry();
    }

    void ClearEntry()
    {
        foreach (Transform child in this.gameObject.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
