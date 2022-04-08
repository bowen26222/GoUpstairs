using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xialou : Interacter
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetButtonDown("Enter") && CanInteract && !flowchart.GetBooleanVariable("IsPause"))
        {
            flowchart.ExecuteBlock(InteractName[0]);
        }
    }
}
