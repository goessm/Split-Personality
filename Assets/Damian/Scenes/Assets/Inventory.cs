using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO when item picked up call EventManager.TriggerEvent("zeitungPickUp");

public class Inventory : MonoBehaviour
{
    void Start()
    {
        makeItemInvisible(0);
        makeItemInvisible(1);
        makeItemInvisible(2);
        makeItemInvisible(3);
    }

    void OnEnable()
    {
        EventManager.StartListening("zeitungPickUp", makeItem0Visible);
        EventManager.StartListening("teddyPickUp", makeItem1Visible);
        EventManager.StartListening("loveletterPickUp", makeItem2Visible);
    }

    void OnDisable()
    {
        EventManager.StopListening("zeitungPickUp", makeItem0Visible);
        EventManager.StopListening("teddyPickUp", makeItem1Visible);
        EventManager.StopListening("loveletterPickUp", makeItem2Visible);
    }

    public static void makeItem0Visible() {
        makeItemVisible(0);
        GameObject worldItem = GameObject.Find("Zeitung");
        worldItem.SetActive(false);
    }

    public static void makeItem1Visible() {
        makeItemVisible(1);
    }

    public static void makeItem2Visible() {
        makeItemVisible(2); // visible im inventar
        GameObject worldItem = GameObject.Find("LoveLetter");
        worldItem.SetActive(false);
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
}
