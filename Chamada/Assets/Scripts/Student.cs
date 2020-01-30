using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student
{
    public string sName;
    public bool gender; // 0 = masculino/ 1 = feminino
    public string birthDate;
    public string instrument;
    public string instrumentNumber;
    public string rg;
    public string cpf;
    public string adress;
    public string citizenCard;
    public string phone;
    public string cellphone;
    public string email;
    public string medicine;
    public bool parentsInfo;
    public string kinship;
    public string parentName;
    public string parentRg;
    public string parentCpf;
    public string parentPhone;
    public string parentCellphone;

    public bool Activity;
    public List<Attendance> attendance = new List<Attendance>(); //lista de presença

    int count;
    int rowCount;

    public int Absences()
    {
        count = 0;
        foreach (Attendance a in attendance)
        {
            if (!a.showedUp)
            {
                count++; 
            }
        }
        return count;
    }//Conta numero de faltas

    public int AbsencesInARow()
    {
        foreach (Attendance a in attendance)
        {
            if (!a.showedUp)
            {
                rowCount++;
            }
            else
            {
                rowCount--;
            }
        }
        if (rowCount>0)
        {
            rowCount = 0;
        }
        return rowCount;
    }//conta faltas consecutivas

    public string ShortName()
    {
        string[] names = sName.Split(' ');
        string finalName = names[0];
        for (int i = 1; i < names.Length; i++)
        {
            string middleName = names[i];
            char abbreviation = middleName[0];
            finalName += " " + abbreviation + ".";
        }
        return finalName;
    }

    public void SetActivity(bool activity)
    {
        Activity = activity;
    }
}
