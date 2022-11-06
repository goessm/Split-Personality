using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden : MonoBehaviour
{

    void OnEnable()
    {
        print("animal enable");
        EventManager.StartListening("SpawnStuffedAnimal", Show);
    }

    void OnDestroy()
    {
        EventManager.StopListening("SpawnStuffedAnimal", Show);
    }


    void Start()
    {
        print("hellow world");
        gameObject.SetActive(false);
    }

    public void Show()
    {
        print("hello");
        gameObject.SetActive(true);
    }


}
