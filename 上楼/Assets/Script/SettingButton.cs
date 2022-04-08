using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingButton : MonoBehaviour
{
    public GameObject Manu, SettingManu;
    public bool IsChange;
    // Start is called before the first frame update
    public void ChangeSettingManu()
    {
        if (!IsChange)
        {
            Manu.SetActive(false);
            SettingManu.SetActive(true);
        }
        else
        {
            Manu.SetActive(true);
            SettingManu.SetActive(false);
        }
    }
}
