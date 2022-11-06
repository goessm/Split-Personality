using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MainLevel : MonoBehaviour
{
    public AudioClip[] Music;

    private int musicIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        PlayNextMusic();
    }

    public void PlayNextMusic()
    {
        if (Music.Length == 0) return;
        if (musicIndex >= Music.Length ) {
            musicIndex = 0;
        }
        SoundManager.Instance.PlayMusic(Music[musicIndex]);
        musicIndex += 1;
        StartCoroutine(SoundManager.Instance.WaitForSilence(SoundManager.Instance.MusicSource, PlayNextMusic));
    }
}
