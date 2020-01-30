using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAbsenceWarning : MonoBehaviour
{
    public Database db;
    public int WarningValue;

    public GameObject popup;
    public GameObject warningTab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AbsenceWarning());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("começo instancia");
            Student sTest = new Student();
            sTest.sName = "Teste Nome";
            GameObject test = Instantiate(popup, warningTab.transform);
            test.GetComponent<WarningPopup>().WarningSetup(sTest);
            Debug.Log("Fim instancia");
        }
    }

    IEnumerator AbsenceWarning()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        if(db.studentList.Count > 0)
        {
            foreach (Student s in db.studentList)
            {
                if (s.AbsencesInARow() > WarningValue & s.Activity)
                {
                    GameObject instantiatedWarning = Instantiate(popup, warningTab.transform);
                    instantiatedWarning.GetComponent<WarningPopup>().WarningSetup(s);
                    yield return new WaitForSecondsRealtime(0.3f);
                }
            }
        }
        else
        {
            yield return null;
        }
    }
}
