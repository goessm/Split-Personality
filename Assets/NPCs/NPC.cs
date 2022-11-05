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
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
