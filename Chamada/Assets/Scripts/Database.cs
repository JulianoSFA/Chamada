using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database:MonoBehaviour
{
    public List<Student> studentList;

    public void Start()
    {
        studentList = new List<Student>();
        //lê o arquivo de save para alimentar a lista
    }
     

    public void ShowList()
    {
        Debug.Log(studentList.Count);
        foreach (Student s in studentList)
        {
            Debug.Log(s.ToString());
        }
    }

}
