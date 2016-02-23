// ゲージ(体力等)

using UnityEngine;
using System.Collections;

public class Gauge : MonoBehaviour
{
    int value;
    int maxValue;
    int level;
    UILabel valueLabel;
    UILabel levelLabel;
    UISlider slider;

    public void Initialize(int value, int maxValue, int level)
    {
        this.value = value;
        this.maxValue = maxValue;
        this.level = level;
    }

    void Start()
    {
        valueLabel = transform.Find("Value").gameObject.GetComponent<UILabel>();
        levelLabel = transform.Find("Level").gameObject.GetComponent<UILabel>();
        slider = GetComponent<UISlider>();
    }

    void Update()
    {
        valueLabel.text = value + "/" + maxValue;
        levelLabel.text = "Lv." + level;
        slider.value = (float)value / maxValue;
    }

    public int GetValue() { return value; }

    public void SetValue(int value) { this.value = value; }

    public int GetMaxValue() { return maxValue; }

    public void SetMaxValue(int maxValue) { this.maxValue = maxValue; }

    public int GetLevel() { return level; }

    public void SetLevel(int level) { this.level = level; }
}
