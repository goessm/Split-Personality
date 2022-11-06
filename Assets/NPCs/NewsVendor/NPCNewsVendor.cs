using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPCNewsVendor : NPC
{

    void Start()
    {
    }

    public void OnFirstConversationFinish()
    {
        EventManager.TriggerEvent("SpawnNewspaper");
    }

}
