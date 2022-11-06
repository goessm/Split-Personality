using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden : MonoBehaviour
{
    public string UnhideEvent;

    void OnEnable()
    {
        EventManager.StartListening(UnhideEvent, Show);
    }

    void OnDestroy()
    {
        EventManager.StopListening(UnhideEvent, Show);
    }


    void Start()
    {
        if (UnhideEvent != null) {
            gameObject.SetActive(false);
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }


}
