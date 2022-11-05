using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void makeItemVisible(int index)
    {
        GameObject invPanel = GameObject.Find("InvPanel");
        GameObject itemSlot = invPanel.transform.GetChild(index).gameObject;
        GameObject item = itemSlot.transform.GetChild(0).gameObject;
        // make invisible
        item.transform.localScale = new Vector3(0,0,0);
    }
}
