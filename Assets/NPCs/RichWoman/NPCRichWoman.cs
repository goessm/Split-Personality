using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPCRichWoman : NPC
{
    private bool introDone = false;

    void Start()
    {
    }

    new private void OnTriggerEnter2D(Collider2D other)
    {
        if (!introDone)
        {
            ConversationManager.Instance.StartConversation(conversations[0]);
            introDone = true;
        } else
        {
            base.OnTriggerEnter2D(other);

        }
    }

}
