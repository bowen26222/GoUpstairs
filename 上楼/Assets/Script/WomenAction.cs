using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomenAction : Interacter
{
    bool dia1, dia2, dia3;
    private void Update()
    {
        dia1 = flowchart.GetBooleanVariable("F2dia1");
        dia2 = flowchart.GetBooleanVariable("F2dia2");
        dia3 = flowchart.GetBooleanVariable("F2dia3");
        if (Input.GetButtonDown("Interact") && CanInteract && !flowchart.GetBooleanVariable("IsPause"))
        {
            ChooseDia();
        }
    }
    void ChooseDia()
    {
        if (dia1)
        {
            flowchart.ExecuteBlock(InteractName[0]);
        }
        if (dia2)
        {
            flowchart.ExecuteBlock(InteractName[1]);
        }
        if (dia3)
        {
            flowchart.ExecuteBlock(InteractName[2]);
        }
    }
    public void EnterRoom()
    {
        gameObject.SetActive(false);
    }
}
