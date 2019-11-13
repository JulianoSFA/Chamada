using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddStudent : MonoBehaviour
{
    public Database db;
    public GameObject slot;
    public GameObject blank;

    public void ShowStudents()
    {
        foreach (Student s in db.studentList)
        {
            GameObject space = Instantiate(slot) as GameObject;
            space.SetActive(true);
            space.GetComponent<StudentViewController>().SetText(s.sName);
            space.transform.SetParent(blank.transform.parent,false);
        }
    }
}
