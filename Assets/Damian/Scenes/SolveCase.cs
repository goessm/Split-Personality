using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolveCase : MonoBehaviour
{
    bool gameEnded = false;
    void Start()
    {
        GameObject textbox1 = GameObject.Find("ChooseBanker");
        textbox1.transform.localScale = new Vector3(0,0,0);
        GameObject textbox2 = GameObject.Find("ChooseBoy");
        textbox2.transform.localScale = new Vector3(0,0,0);
        GameObject textbox3 = GameObject.Find("ChooseGirl");
        textbox3.transform.localScale = new Vector3(0,0,0);
        GameObject textbox4 = GameObject.Find("ChooseVictim");
        textbox4.transform.localScale = new Vector3(0,0,0);
    }

    void EndGame()
    {
        gameEnded = true;
    }

    public void SetBanker()
    {
        if (gameEnded) return;
        GameObject textbox = GameObject.Find("ChooseBanker");
        textbox.transform.localScale = new Vector3(1,1,1);
        EndGame();
    }

    public void SetBoy()
    {
        if (gameEnded) return;
        GameObject textbox = GameObject.Find("ChooseBoy");
        textbox.transform.localScale = new Vector3(1,1,1);
        EndGame();
    }

    public void SetGirl()
    {
        if (gameEnded) return;
        GameObject textbox = GameObject.Find("ChooseGirl");
        textbox.transform.localScale = new Vector3(1,1,1);
        EndGame();
    }

    public void SetVictim()
    {
        if (gameEnded) return;
        GameObject textbox = GameObject.Find("ChooseVictim");
        textbox.transform.localScale = new Vector3(1,1,1);
        EndGame();
    }
}
