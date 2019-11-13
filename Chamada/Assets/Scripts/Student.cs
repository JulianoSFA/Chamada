using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student
{
    public string sName;
    public bool gender; // 0 = male/ 1 = female
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

    public string StudentInfo()
    {
        string info = string.Format("Nome:{0} Gênero:{1} Data de nascimento:{2} Instrumento:{3} N° do instrumento:{4} RG:{5} CPF:{6} Endereço:{7}", sName, gender, birthDate, instrument, instrumentNumber, rg, cpf, adress);
        return info;
    }
}
