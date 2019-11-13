using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentEntry : MonoBehaviour
{
    public Database db;
    public GameObject Button;
    public GameObject blankSpace;

    public void SpawnStudentButton()
    {
        if(db.studentList.Count > 0)
        {
            foreach (Student s in db.studentList)
            {
                GameObject InstantiatedButton = Instantiate(Button);
                InstantiatedButton.transform.SetParent(transform, false);
                InstantiatedButton.GetComponent<ShowStudent>().SetNames(s.sName, s.instrument);
            }
            blankSpace.SetActive(false);
        }
        else
        {
            blankSpace.SetActive(true);
        }
        
    }
}
