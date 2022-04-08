using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    public GameObject[] SceneObject;
    void Start()
    {
        
    }

    public void SetObject(int num)
    {
        SceneObject[num].SetActive(true);
    }

}
