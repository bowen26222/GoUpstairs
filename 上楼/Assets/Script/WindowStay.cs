using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowStay : Interacter
{
    public float SetTime;
    float PassTime;
    bool IsFinished = false;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (CanInteract)
        {
            PassTime += Time.deltaTime;
        }
        if (PassTime >= SetTime && !IsFinished)
        {
            IsFinished = true;
            flowchart.ExecuteBlock(InteractName[0]);
        }
    }
}
