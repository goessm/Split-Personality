using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPCLittleGirl : MonoBehaviour
{
    public NPCConversation[] conversations;
    private int conversationIndex = 0;

    void Start()
    {
    }
    public void talkToNpc()
    {
        ConversationManager.Instance.StartConversation(conversations[conversationIndex]);
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            print("hihi");
            talkToNpc();
        }
    }
}
