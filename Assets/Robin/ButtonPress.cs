using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    private bool switching = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void GotoMain()
    {
        if (!switching) {
            switching = true;
            SceneManager.LoadScene("Main Scene");
        }
    }
}
