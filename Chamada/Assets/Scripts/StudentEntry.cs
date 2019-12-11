using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentEntry : MonoBehaviour
{
    public Database db;
    public GameObject Button;
    public GameObject blankSpace;

    GameObject content;

    private void Start()
    {
        content = this.gameObject;
    }

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
        yield return new WaitForSeconds(1f);
    }

    public void ComputeAttendance()
    {
        List<GameObject> childList = new List<GameObject>();
        for (int i = 0; i < content.transform.childCount; i++)
        {
            childList.Add(content.transform.GetChild(i).gameObject);
            Debug.Log("Novo registo" + childList[i].name);
        }
        foreach (GameObject child in childList)
        {
            child.GetComponent<ShowStudent>().SetAttendance();
            Debug.Log(child.GetComponent<ShowStudent>().sName.ToString());
        }
    }

    public void ClearEntry()
    {
        foreach (Transform child in content.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
