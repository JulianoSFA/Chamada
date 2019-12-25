using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAbsenceWarning : MonoBehaviour
{
    public Database db;
    public int WarningValue;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(AbsenceWarning());
    }

    IEnumerator AbsenceWarning()
    {
        List<GameObject> items = new List<GameObject>();
        foreach (Student s in db.studentList)
        {
            if (s.AbsencesInARow() > WarningValue)
            {
                //instancia um pop-up no menu principal fazendo um alerta com o nome da pessoa
                //adiciona a instancia na lista "items"
                new WaitForSecondsRealtime(0.2f);
            }
            else
                break;
        }

        new WaitForSecondsRealtime(5);
    
        foreach (GameObject i in items)
        {
            Destroy(i);
            new WaitForSecondsRealtime(0.5f);
        }

        yield return null;
    }

}
