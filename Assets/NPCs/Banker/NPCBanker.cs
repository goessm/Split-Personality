using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPCBanker : NPC
{
    void OnEnable()
    {
        EventManager.StartListening("loveletterPickUp", UnlockConvo2);
    }

    void OnDisable()
    {
        EventManager.StopListening("loveletterPickUp", UnlockConvo2);
    }

    void Start()
    {
    }

    void UnlockConvo2()
    {
        changeConversation(1);
    }

    public void SpawnStuffedAnimal()
    {
        EventManager.TriggerEvent("SpawnStuffedAnimal");
    }

}
