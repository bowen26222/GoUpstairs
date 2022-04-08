using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ManuButton : MonoBehaviour
{
    public void BackManu()
    {
        SceneManager.LoadScene("Manu");
    }
}
