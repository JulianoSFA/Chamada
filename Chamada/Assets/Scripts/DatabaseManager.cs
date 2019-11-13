using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DatabaseManager:MonoBehaviour
{
    Database db;
    public TMP_InputField sName;
    public TMP_Dropdown gender; // 0 = male/ 1 = female
    public TMP_InputField birthDate;
    public TMP_InputField instrument;
    public TMP_InputField instrumentNumber;
    public TMP_InputField rg;
    public TMP_InputField cpf;
    public TMP_InputField adress;
    public TMP_InputField citizenCard;
    public TMP_InputField phone;
    public TMP_InputField cellphone;
    public TMP_InputField email;
    public TMP_InputField medicine;
    public Toggle parentsInfo;
    public TMP_InputField kinship;
    public TMP_InputField parentName;
    public TMP_InputField parentRg;
    public TMP_InputField parentCpf;
    public TMP_InputField parentPhone;
    public TMP_InputField parentCellphone;

    private void Start()
    {
        db = GetComponent<Database>();
    }

    public void AddData()
    {
        db.studentList.Add(CreateData(new Student()));
        foreach (Student s in db.studentList)
        {
            Debug.Log(s.StudentInfo());
        }
    }

    Student CreateData(Student s)
    {
        s.sName = sName.text;
        if (gender.value == 0)
            s.gender = false;
        else
            s.gender = true;
        s.birthDate = birthDate.text;
        s.instrument = instrument.text;
        s.instrumentNumber = instrumentNumber.text;
        s.rg = rg.text;
        s.cpf = cpf.text;
        s.adress = adress.text;
        s.citizenCard = citizenCard.text;
        s.phone = phone.text;
        s.cellphone = cellphone.text;
        s.email = email.text;
        s.medicine = medicine.text;
        if (parentsInfo)
        {
            s.kinship = kinship.text;
            s.parentName = parentName.text;
            s.parentRg = parentRg.text;
            s.parentCpf = parentCpf.text;
            s.parentPhone = parentPhone.text;
            s.parentCellphone = parentCellphone.text;
        }
        else
        {
            s.kinship = null;
            s.parentName = null;
            s.parentRg = null;
            s.parentCpf = null;
            s.parentPhone = null;
            s.parentCellphone = null;
        }
        s.Activity = true;
        return s;
    }

    public void ClearRegister()
    {
        sName.text = null;
        gender.value = 0;
        birthDate.text = null;
        instrument.text = null;
        instrumentNumber.text = null;
        rg.text = null;
        cpf.text = null;
        adress.text = null;
        citizenCard.text = null;
        phone.text = null;
        cellphone.text = null;
        email.text = null;
        medicine.text = null;
        parentsInfo.enabled = false;
        kinship.text = null;
        parentName.text = null;
        parentRg.text = null;
        parentCpf.text = null;
        parentPhone.text = null;
        parentCellphone.text = null;
    }

}
