using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public abstract class NPC : MonoBehaviour
{

    public NPCConversation[] conversations;
    private int conversationIndex = 0;
    public void talkToNpc()
    {
        if (conversations.Length > 0)
        {
            ConversationManager.Instance.StartConversation(conversations[conversationIndex]);
        }
    }

    public void nextConversation()
    {
        if (conversationIndex < conversations.Length) {
            conversationIndex += 1;
        }
    }

    public void changeConversation(int index) {
        conversationIndex = index;
    }
}
