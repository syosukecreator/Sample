// 日付を管理するクラス

using UnityEngine;
using System.Collections;

public class Day : MonoBehaviour
{
    UILabel label;
    int day;
    public GameObject alertPrefab;
    public GameObject alertGeneratePoint;

    // Use this for initialization
    void Start()
    {
        label = GetComponent<UILabel>();

        day = ConstantParameter.Instance.GetDay();

        UpdateDay();
    }

    void UpdateDay()
    {
        string dayString = "";
        switch (day % 2)
        {
            case 0:
                dayString = "(昼)";
                break;

            case 1:
                dayString = "(夜)";
                break;
        }

        label.text = (day / 2) + "日目" + dayString;
    }

    public void CountDay()
    {
        ++day;
        ConstantParameter.Instance.SetDay(day);

        string displayString = "";
        if (day % 2 == 0)
        {
            displayString = "日付が変わりました";
        }
        else
        {
            displayString = "時間帯が変わりました";
        }

        GameObject alertGo = NGUITools.AddChild(alertGeneratePoint, alertPrefab);
        alertGo.GetComponent<UILabel>().text = displayString;

        UpdateDay();
    }
}
