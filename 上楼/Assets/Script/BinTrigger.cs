using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class BinTrigger : MonoBehaviour
{
    public float WaitTime;
    public string SetBin;
    Animator Anim;
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "cat")
        {
            Anim.SetBool("IsFall", true);
            StartCoroutine(Wait(WaitTime));   
        }
    }
    IEnumerator Wait(float t)
    {
        yield return new WaitForSeconds(t);//运行到这，暂停t秒
        flowchart.ExecuteBlock(SetBin);
    }
}
