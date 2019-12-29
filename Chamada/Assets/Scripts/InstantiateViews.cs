﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateViews : MonoBehaviour
{
    public Database db;
    public GameObject studentView;

    private void OnEnable()
    {
        StartCoroutine("InstantiateStudentView");
    }

    private void OnDisable()
    {
        StopCoroutine("InstantiateStudentView");
        foreach (Transform child in this.transform)
        {
            Destroy(child.gameObject);
        }
    }

    IEnumerator InstantiateStudentView()
    {
        foreach (Student s in db.studentList)
        {
            GameObject view = Instantiate(studentView, this.transform);
            view.GetComponent<ShowViewValues>().Student = s;
        }
        yield return null;
    }
}