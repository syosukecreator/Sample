// タイトルを読み込む

using UnityEngine;
using System.Collections;

public class LoadTitleScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("_LoadTitleScene", 2);
	}

    void _LoadTitleScene()
    {
        SceneManager.Instance.LoadScene("Title");
    }
}
