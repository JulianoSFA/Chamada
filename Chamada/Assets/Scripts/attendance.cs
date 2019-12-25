using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attendance
{
    public DateTime date;
    public bool showedUp;

    public Attendance(DateTime d, bool sU)
    {
        date = d;
        showedUp = sU;
    }
}
