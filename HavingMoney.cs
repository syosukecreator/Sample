// 所持金表示

using UnityEngine;
using System.Collections;

public class HavingMoney : Singleton<HavingMoney>
{
    UILabel moneyLabel;

    void Start()
    {
        moneyLabel = GetComponent<UILabel>();
        moneyLabel.text = "所持金 : " + ConstantParameter.Instance.money + "G";
    }

    public void UpdateMoney()
    {
        moneyLabel.text = "所持金 : " + ConstantParameter.Instance.money + "G";
    }
}
