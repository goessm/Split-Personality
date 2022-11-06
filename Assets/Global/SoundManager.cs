using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoundManager : MonoBehaviour
{
	// Audio players components.
	public AudioSource EffectsSource;
	public AudioSource MusicSource;
	// Random pitch adjustment range.
	public float LowPitchRange = .95f;
	public float HighPitchRange = 1.05f;
	// Singleton instance.
	public static SoundManager Instance = null;
	
	// Initialize the singleton instance.
	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else if (Instance != this)
		{
			Destroy(gameObject);
		}
	}
	// Play a single clip through the sound effects source.
	public void Play(AudioClip clip)
	{
		EffectsSource.clip = clip;
		EffectsSource.Play();
	}
	// Play a single clip through the music source.
	public void PlayMusic(AudioClip clip)
	{
        print("playing music");
        print(clip);
		MusicSource.clip = clip;
		MusicSource.Play();
	}
	// Play a random clip from an array, and randomize the pitch slightly.
	public void RandomSoundEffect(params AudioClip[] clips)
	{
		int randomIndex = Random.Range(0, clips.Length);
		float randomPitch = Random.Range(LowPitchRange, HighPitchRange);
		EffectsSource.pitch = randomPitch;
		EffectsSource.clip = clips[randomIndex];
		EffectsSource.Play();
	}

    public IEnumerator WaitForSilence(AudioSource audioSource, UnityAction then)
    {
       yield return new WaitUntil(() => audioSource.isPlaying == false);
       then();
    }
	
}