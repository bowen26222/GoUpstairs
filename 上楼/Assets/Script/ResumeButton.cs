using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class ResumeButton : MonoBehaviour
{
    public GameObject Manu;
    Flowchart flowchart;
    private void Start()
    {
        flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
    }
    public void Resume()
    {
        if(!flowchart.HasExecutingBlocks())
            flowchart.SetBooleanVariable("IsPause", false);
        Manu.SetActive(false);
    }
}
