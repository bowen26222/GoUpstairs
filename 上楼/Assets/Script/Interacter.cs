using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class Interacter : MonoBehaviour
{
    public string[] InteractName;
    public bool CanInteract; 
    public Flowchart flowchart;
    public void Awake()
    {
        CanInteract = false;
        flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
    }
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        CanInteract = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        CanInteract = false;
    }

}
