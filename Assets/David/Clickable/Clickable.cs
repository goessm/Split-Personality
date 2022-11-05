using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Clickable : MonoBehaviour
{
    public UnityEvent OnClick;
    void OnMouseDown()
    {
        print("clicked!");
        if (!GameState.monokel) print("But monokel was off...");
        if (OnClick != null) OnClick.Invoke();
    }
}
