using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    void EndGame(bool correctChoice)
    {
        gameEnded = true;
        if (correctChoice) {
            SoundManager.Instance.Play(SoundManager.Instance.correctClip);
        } else {
            SoundManager.Instance.Play(SoundManager.Instance.wrongClip);
        }

        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Menu");
    }

    public void SetBanker()
    {
        if (gameEnded) return;
        GameObject textbox = GameObject.Find("ChooseBanker");
        textbox.transform.localScale = new Vector3(1,1,1);
        EndGame(false);
    }

    public void SetBoy()
    {
        if (gameEnded) return;
        GameObject textbox = GameObject.Find("ChooseBoy");
        textbox.transform.localScale = new Vector3(1,1,1);
        EndGame(true);
    }

    public void SetGirl()
    {
        if (gameEnded) return;
        GameObject textbox = GameObject.Find("ChooseGirl");
        textbox.transform.localScale = new Vector3(1,1,1);
        EndGame(false);
    }

    public void SetVictim()
    {
        if (gameEnded) return;
        GameObject textbox = GameObject.Find("ChooseVictim");
        textbox.transform.localScale = new Vector3(1,1,1);
        EndGame(false);
    }
}
