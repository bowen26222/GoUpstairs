using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class StoryController : MonoBehaviour
{
    public string StoryName;
    bool IsTriggered;
    public Flowchart flowchart;
    private void Awake()
    {
        flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
        IsTriggered = false;   
    }
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!IsTriggered && collision.gameObject.tag == "Player" && !flowchart.GetBooleanVariable("IsPause"))
        {
            print(1);
            IsTriggered = true;
            flowchart.ExecuteBlock(StoryName);
        }
    }
}
