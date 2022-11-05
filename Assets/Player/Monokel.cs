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
}
