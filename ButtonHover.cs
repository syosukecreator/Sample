// ボタンにカーソルを合わせたときに表示する

using UnityEngine;
using System.Collections;

public class ButtonHover : MonoBehaviour
{
    public string itemName = "名前";
    [Multiline]
    public string explanation = "説明";
    [Range(100, 10000)]
    public int itemMoneyCost = 1000;
    UILabel itemNameLabel;
    UILabel explanationLabel;
    UILabel moneyLabel;
    GameObject lockObject;
    DialogManager dialog;
   public ItemLockChecker itemLockChecker;

    void Start()
    {
        itemNameLabel = GameObject.Find("ItemNameLabel").GetComponent<UILabel>();
        explanationLabel = GameObject.Find("ExplanationLabel").GetComponent<UILabel>();
        moneyLabel = GameObject.Find("MoneyLabel").GetComponent<UILabel>();
        lockObject = transform.Find("Lock").gameObject;
        dialog = GameObject.Find("Dialog").GetComponent<DialogManager>();
        itemLockChecker = GetComponent<ItemLockChecker>();
    }

    void OnHover(bool isOver)
    {
        if (isOver)
        {
            dialog.buttonHover = this;

            itemNameLabel.text = "～" + itemName + "～";
            explanationLabel.text = explanation;
            if (lockObject.activeSelf == true)
            {
                moneyLabel.text = "値段：" + itemMoneyCost + "G";
            }
            else {
                moneyLabel.text = "";
            }
        }
    }
}
