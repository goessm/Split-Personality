using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.SceneManagement;

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

    public void GotoChooseScene()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
{
    yield return new WaitForSeconds(4);
    SceneManager.LoadScene("SolveCase");
}

    public void SpawnStuffedAnimal()
    {
        EventManager.TriggerEvent("SpawnStuffedAnimal");
    }

}
