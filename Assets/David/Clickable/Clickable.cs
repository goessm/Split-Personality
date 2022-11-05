using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Clickable : MonoBehaviour
{
    public UnityEvent OnClick;
    public UnityEvent OnMonokelClick;
    void OnMouseDown()
    {
        print("clicked!");
        if (GameState.monokel)
        {
            OnMonokelClick.Invoke();
        } else
        {
            OnClick.Invoke();
        }
    }
}
