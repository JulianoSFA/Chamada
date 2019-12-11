using UnityEngine;
using TMPro;

public class StudentViewController : MonoBehaviour
{
    public TextMeshProUGUI sName;

    public void SetText(string text)
    {
        sName.text = text;
    }
}
