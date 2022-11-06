using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPCBanker : NPC
{

    void Start()
    {
    }

    public void SpawnStuffedAnimal()
    {
        nextConversation();
        EventManager.TriggerEvent("SpawnStuffedAnimal");
    }

}
