// アイテムを購入するときに表示するダイアログ

using UnityEngine;
using System.Collections;

public class DialogManager : Singleton<DialogManager>
{
    public GameObject showPoint;
    public GameObject hidePoint;
    public GameObject confirmObject;
    public ButtonHover buttonHover;
    public ButtonHover savedButtonHover;
    UILabel questionLabel;
    int cost;
    public AudioClip buySound;
    AudioSource audioSource;

    void Start()
    {
        this.transform.localPosition = hidePoint.transform.localPosition;
        confirmObject.transform.localPosition = hidePoint.transform.localPosition;

        questionLabel = transform.Find("QuestionLabel").gameObject.GetComponent<UILabel>();

        audioSource = GetComponent<AudioSource>();
    }

    public void ShowDialog()
    {
        savedButtonHover = buttonHover;

        int money = ConstantParameter.Instance.money;
        cost = buttonHover.itemMoneyCost;

        if (money - buttonHover.itemMoneyCost < 0)
        {
            confirmObject.transform.localPosition = showPoint.transform.localPosition;
        }
        else
        {
            this.transform.localPosition = showPoint.transform.localPosition;

            questionLabel.text = buttonHover.itemName + "を" + buttonHover.itemMoneyCost + "Gで購入しますか？";
        }
    }

    public void Yes()
    {
        this.transform.localPosition = hidePoint.transform.localPosition;
        ConstantParameter.Instance.money -= cost;
        HavingMoney.Instance.UpdateMoney();

        ConstantParameter.Instance.itemLock.SetIsLock(savedButtonHover.itemLockChecker.trainingMode, false);
        savedButtonHover.itemLockChecker.UpdateLock();
        audioSource.PlayOneShot(buySound);
    }

    public void No()
    {
        this.transform.localPosition = hidePoint.transform.localPosition;
    }

    public void Ok()
    {
        confirmObject.transform.localPosition = hidePoint.transform.localPosition;
    }
}
