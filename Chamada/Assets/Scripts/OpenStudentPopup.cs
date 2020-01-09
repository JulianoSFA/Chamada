using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStudentPopup : MonoBehaviour
{
    void OpenPopup(GameObject scene, Student student)
    {
        scene.SetActive(true);
        scene.GetComponent<Visual>().student = student;
    }
}
