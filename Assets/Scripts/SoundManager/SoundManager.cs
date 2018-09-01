using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour {
    private AudioClip[] clips;
    private AudioSource audioSource;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    void Start()
    {
        clips = Resources.LoadAll<AudioClip>("Audio/Music");
        audioSource = FindObjectOfType<AudioSource>();
        AudioMixer audioMixer = Resources.Load<AudioMixer>("Audio/MasterMixer");
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
