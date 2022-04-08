using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class MoveScene : MonoBehaviour
{
    public SpriteRenderer Flash; 
    Flowchart flowchart;
    Color Target;
    public float FlashSpeed;
    bool IsFinished;
    // Start is called before the first frame update
    void Start()
    {
        flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
        IsFinished = false;
    }

    // Update is called once per frame
    void Update()
    {
        Flash.color = Color.Lerp(Flash.color, Target, FlashSpeed * Time.deltaTime);
        if (IsChanged() && !IsFinished)
        {
            IsFinished = true;
            flowchart.SetBooleanVariable("IsPause", false);
        }   
        
    }
    public void EndScene()
    {
        Flash.color = Color.clear;
        Target = Color.black;
        flowchart.SetBooleanVariable("IsPause", true);
    }
    public void StartScene()
    {
        Flash.color = Color.black;
        Target = Color.clear;
        flowchart.SetBooleanVariable("IsPause", true);
    }
    public bool IsChanged()
    {
        if (Flash.color.a >= 0.9&&Target==Color.black)
        {
            return true;
        }
        else if (Flash.color.a <=0.1 && Target == Color.clear)
        {
            return true;
        }
        else return false;
    }
}
