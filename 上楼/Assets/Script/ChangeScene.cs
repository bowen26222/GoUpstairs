using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Fungus;
public class ChangeScene : Interacter
{
    public string SceneName;
    public SpriteRenderer SP;
    public bool IsChanged;
    // Start is called before the first frame update\
    public void Start()
    {
        IsChanged = false;
        SP = GameObject.Find("ScreenMask").GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Enter") && CanInteract && !IsChanged)
        {
            Change();
        }
        if (SP.color.a > 0.9 && IsChanged)
            SceneManager.LoadScene(SceneName);
    }
    public void Change()
    {
        IsChanged = true;
        flowchart.ExecuteBlock("Leave");
        flowchart.SetIntegerVariable("test", flowchart.GetIntegerVariable("test") + 1);
    }
}
