using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPCLittleGirl : NPC
{

    void OnEnable()
    {
        EventManager.StartListening("stuffedAnimalPickUp", UnlockConvo2);
    }

    void OnDisable()
    {
        EventManager.StopListening("stuffedAnimalPickUp", UnlockConvo2);
    }

    void Start()
    {
    }

    void UnlockConvo2()
    {
        changeConversation(1);
    }

    public void GiveLoveLetter()
    {
        EventManager.TriggerEvent("loveletterPickUp");
    }


    
}
