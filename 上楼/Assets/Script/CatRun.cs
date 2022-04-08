using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatRun : MonoBehaviour
{
    public float WaitTime;
    Rigidbody2D Rig;
    public float CatSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
        Rig.velocity = new Vector2(CatSpeed, 0);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bin")
        {
            StartCoroutine(Wait(WaitTime));
        }
    }
    IEnumerator Wait(float t)
    {
        yield return new WaitForSeconds(t);//运行到这，暂停t秒
        GameObject.Find("猫").SetActive(false);
    }
}
