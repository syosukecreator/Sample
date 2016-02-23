// 吹き出し

using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour
{
    string serif;
    [Range(1, 10)]
    public int displayTime = 2;
    UILabel label;

    void Start()
    {
        label = GetComponent<UILabel>();
        label.text = "";

        Invoke("DestroyMyself", 4);
    }

    void Update()
    {
        label.text = serif;
    }

    public void SetSerif(string serif)
    {
        this.serif = serif;
    }

    void DestroyMyself()
    {
        Destroy(this.gameObject);
    }
}
