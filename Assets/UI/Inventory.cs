using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO when item picked up call EventManager.TriggerEvent("zeitungPickUp");

public class Inventory : MonoBehaviour
{
    void Start()
    {
        //Time.timeScale = 8;
        makeItemInvisible(0);
        makeItemInvisible(1);
        makeItemInvisible(2);
        makeItemInvisible(3);
    }

    void OnEnable()
    {
        EventManager.StartListening("zeitungPickUp", makeItem0Visible);
        EventManager.StartListening("stuffedAnimalPickUp", makeItem1Visible);
        EventManager.StartListening("loveletterPickUp", makeItem2Visible);
        EventManager.StartListening("eastereggPickUp", makeItem3Visible);
    }

    void OnDisable()
    {
        EventManager.StopListening("zeitungPickUp", makeItem0Visible);
        EventManager.StopListening("stuffedAnimalPickUp", makeItem1Visible);
        EventManager.StopListening("loveletterPickUp", makeItem2Visible);
        EventManager.StopListening("eastereggPickUp", makeItem3Visible);
    }

    public static void findAndSetInactive(string name)
    {
        GameObject worldItem = GameObject.Find(name);
        worldItem.SetActive(false);
    }

    public static void makeItem0Visible() {
        makeItemVisible(0);
        findAndSetInactive("Zeitung");
        SoundManager.Instance.Play(SoundManager.Instance.getItemClip);
    }

    public static void makeItem1Visible() {
        makeItemVisible(1);
        findAndSetInactive("StuffedAnimal");
        SoundManager.Instance.Play(SoundManager.Instance.getItemClip);
    }

    public static void makeItem2Visible() {
        makeItemVisible(2);
        SoundManager.Instance.Play(SoundManager.Instance.getItemClip);
    }

    public static void makeItem3Visible() {
        makeItemVisible(3);
        findAndSetInactive("EasterEgg");
        SoundManager.Instance.Play(SoundManager.Instance.getItemClip);
    }

    public static void makeItemVisible(int index)
    {
        GameObject invPanel = GameObject.Find("InvPanel");
        GameObject itemSlot = invPanel.transform.GetChild(index).gameObject;
        GameObject item = itemSlot.transform.GetChild(0).gameObject;
        item.SetActive(true);
    }

    public static void makeItemInvisible(int index)
    {
        GameObject invPanel = GameObject.Find("InvPanel");
        GameObject itemSlot = invPanel.transform.GetChild(index).gameObject;
        GameObject item = itemSlot.transform.GetChild(0).gameObject;
        item.SetActive(false);
    }

    public static void onInvItemClick0() { onInvItemClick(0); }
    public static void onInvItemClick1() { onInvItemClick(1); }
    public static void onInvItemClick2() { onInvItemClick(2); }
    public static void onInvItemClick3() { onInvItemClick(3); }

    public static void onInvItemClick(int index)
    {
        GameObject invPanel = GameObject.Find("InvPanel");
        GameObject itemSlot = invPanel.transform.GetChild(index).gameObject;
        GameObject item = itemSlot.transform.GetChild(0).gameObject;
        GameObject itemTooltip = item.transform.GetChild(0).gameObject;
        itemTooltip.SetActive(!itemTooltip.activeSelf);
    }
}
