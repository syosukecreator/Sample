/* 
   このスクリプトをつけたオブジェクトはシーンを読み込んだときに破壊されない。
   シーンを越えて使用するオブジェクトに使用する。
 */

using UnityEngine;
using System.Collections;

public class DontDestroyObject : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this);
    }
}
