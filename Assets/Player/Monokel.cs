using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monokel : MonoBehaviour
{
    private bool monokel = false;
    void MonokelOn()
    {
        if (monokel) return;
        monokel = true;
        EventManager.TriggerEvent("MonokelOn");
    }

    void MonokelOff()
    {
        if (!monokel) return;
        monokel = false;
        EventManager.TriggerEvent("MonokelOff");
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;
    }
}
