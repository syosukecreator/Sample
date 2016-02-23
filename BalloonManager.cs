// 吹き出しを生成するクラス

using UnityEngine;
using System.Collections;

public class BalloonManager : Singleton<BalloonManager>
{
    public GameObject balloonPrefab;
    GameObject balloonGeneratePoint;
    GameObject createdBalloonObject;
    bool isBalloonActive = false;

    void Start()
    {
        balloonGeneratePoint = GameObject.Find("UiRoot/BalloonGeneratePoint");
    }

    public void CreateBalloon(string serif, bool overWriting)
    {
        if (overWriting)
        {
            _CreateBalloon(serif);
        }
        else
        {
            if (isBalloonActive == false)
            {
                _CreateBalloon(serif);
            }
        }
    }

    void _CreateBalloon(string serif)
    {
        isBalloonActive = true;
        Invoke("SetFalseBalloonActive", 6);    // この4はBalloonの秒数より多い必要がある
        Destroy(createdBalloonObject);
        createdBalloonObject = NGUITools.AddChild(balloonGeneratePoint, balloonPrefab);
        createdBalloonObject.GetComponent<Balloon>().SetSerif(serif);
    }

    public void SetFalseBalloonActive()
    {
        isBalloonActive = false;
    }
}
