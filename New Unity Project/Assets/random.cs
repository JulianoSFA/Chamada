using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class random : MonoBehaviour
{
    public TextMeshProUGUI text;
    List<int> valueList;

    void Start()
    {
        text.text = string.Empty;
        valueList = new List<int>();
        for (int i = 0; i < 20; i++)
        {
            
            valueList.Add(RandomValue());
        }

        valueList.Sort();

        for (int i = 0; i < valueList.Count; i++)
        {
            text.text += valueList[i].ToString() + " ";
        }
    }

    int RandomValue()
    {
        int value = Random.Range(1, 60);
        foreach (int v in valueList)
        {
            if (value == v)
            {
                RandomValue();
            }
        }
        return value;
    }
}
