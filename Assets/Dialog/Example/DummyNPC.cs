using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DummyNPC : MonoBehaviour
{
    public NPCConversation conversation;

    void Start()
    {
        talkToNpc();
    }
    public void talkToNpc()
    {
        ConversationManager.Instance.StartConversation(conversation);
    }
}
