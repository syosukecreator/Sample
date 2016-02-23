// シーン切り替えを管理する

using UnityEngine;
using System.Collections;

public class SceneManager : Singleton<SceneManager>
{
    public Texture maskTexture;
    bool isLoading = false;
    string sceneName;

    void Start()
    {
        FadeCamera.Instance.UpdateMaskTexture(maskTexture);
        FadeSwitch.IsFadeIn = true;
    }

    public void LoadScene(string sceneName)
    {
        if (!isLoading)
        {
            isLoading = true;
            FadeSwitch.IsFadeIn = false;
            this.sceneName = sceneName;
        }
    }

    void FadeFinished()
    {
        if (isLoading) {
            Application.LoadLevel(sceneName);
            FadeSwitch.IsFadeIn = true;
            isLoading = false;
        }
    }
}
