using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class ManuController : MonoBehaviour
{
    public bool IsManu;
    // Start is called before the first frame update
    public GameObject Manu;
    public GameObject SettingManu;
    Flowchart flowchart;
    void Start()
    {
        IsManu = false;
        flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("esc"))
        {
            if (!Manu.activeSelf)
            {
                IsManu = true;
                flowchart.SetBooleanVariable("IsPause", true);
                Manu.SetActive(true);
                if (SettingManu.activeSelf)
                {
                    SettingManu.SetActive(false);
                }

            }
            else if (Manu.activeSelf)
            {
                IsManu = false;
                if (!flowchart.HasExecutingBlocks())
                    flowchart.SetBooleanVariable("IsPause", false);
                Manu.SetActive(false);
            }
        }
    }
}
