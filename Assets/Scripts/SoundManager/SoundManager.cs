using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour {
    public AudioClip[] clips;
    private AudioSource audioSource;
    public AudioMixer audioMixer;
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.outputAudioMixerGroup = audioMixer.FindMatchingGroups("Music")[0];
        audioSource.loop = false;
    }

    private AudioClip getRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }
    // Update is called once per frame
    void Update () {
		if(!audioSource.isPlaying)
        {
            audioSource.clip = getRandomClip();
            audioSource.Play();
        }
	}
}
