// ゲームを通しての共通操作

using UnityEngine;
using System.Collections;

public class CommonOperation : MonoBehaviour
{
    // Escキーを押されたらアプリケーションを終了する
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) Application.Quit();
    }
}
