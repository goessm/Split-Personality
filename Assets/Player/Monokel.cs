using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Monokel : MonoBehaviour
{
    private bool monokel = false;
    
    public void OnMonokelInput(InputAction.CallbackContext ctx)
    {
        print("monokel key pressed");
        if (ctx.performed) {
            ToggleMonokel();
        }
    }

    public void ToggleMonokel()
    {
        if (monokel) {
            MonokelOff();
        } else {
            MonokelOn();
        }
    }
    public void MonokelOn()
    {
        if (monokel) return;
        monokel = true;
        gameObject.SetActive(monokel);
        EventManager.TriggerEvent("MonokelOn");
        GameState.monokel = monokel;
    }

    public void MonokelOff()
    {
        if (!monokel) return;
        monokel = false;
        gameObject.SetActive(monokel);
        EventManager.TriggerEvent("MonokelOff");
        GameState.monokel = monokel;
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;
    }
}
