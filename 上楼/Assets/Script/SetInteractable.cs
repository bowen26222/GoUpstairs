using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetInteractable : MonoBehaviour
{
    GameObject[] Buttons;
    private void Start()
    {
        Buttons = GameObject.FindGameObjectsWithTag("button");
    }
    public void SetFalse()
    {
        foreach(var button in Buttons)
        {
            button.GetComponent<Button>().interactable = false;
        }
    }
}
