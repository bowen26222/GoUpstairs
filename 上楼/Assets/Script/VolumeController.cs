using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Fungus;

public class VolumeController : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider m_Silder;
    public AudioSource audioSource;
    public float MaxVolume;
    Flowchart flowchart;
    void Start()
    {
        flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
        MaxVolume = flowchart.GetFloatVariable("MaxVolume");
        m_Silder.value = flowchart.GetFloatVariable("Volume");
        if(!m_Silder)
            m_Silder = GetComponent<Slider>();
        GameObject[] gameObjects = getDontDestroyOnLoadGameObjects();
        foreach(var m_gameObject in gameObjects)
        {
            if(m_gameObject.name == "FungusManager")
            {
                AudioSource[] audioSources = m_gameObject.GetComponents<AudioSource>();
                foreach(var m_audioSource in audioSources)
                {
                    if (m_audioSource.clip != null)
                    {
                        audioSource = m_audioSource;
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = MaxVolume * m_Silder.value;
        flowchart.SetFloatVariable("Volume", m_Silder.value);
    }
    private GameObject[] getDontDestroyOnLoadGameObjects()
    {
        var allGameObjects = new List<GameObject>();
        allGameObjects.AddRange(FindObjectsOfType<GameObject>());
        //移除所有场景包含的对象
        for (var i = 0; i < SceneManager.sceneCount; i++)
        {
            var scene = SceneManager.GetSceneAt(i);
            var objs = scene.GetRootGameObjects();
            for (var j = 0; j < objs.Length; j++)
            {
                allGameObjects.Remove(objs[j]);
            }
        }
        //移除父级不为null的对象
        int k = allGameObjects.Count;
        while (--k >= 0)
        {
            if (allGameObjects[k].transform.parent != null)
            {
                allGameObjects.RemoveAt(k);
            }
        }
        return allGameObjects.ToArray();
    }
}
