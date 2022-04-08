using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneInOneFloor : ChangeScene
{
    public Scene NowScene;
    public Scene NeedScene;
    bool IsLoad = false;
    void Update()
    {
        NowScene = SceneManager.GetActiveScene();
        if (!IsLoad)
        {
            SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);
            IsLoad = true;
        }
        if (Input.GetButtonDown("Enter") && CanInteract && !IsChanged)
        {
            Change();
        }
        if (SP.color.a > 0.9 && IsChanged)
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(SceneName));
        }
            
    }
}
