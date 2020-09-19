﻿using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{


    public Sound[] sounds;


    private void Awake()
    {

        foreach (Sound sound in sounds)
        {

            sound.audioSource = gameObject.AddComponent<AudioSource>();
            sound.audioSource.clip = sound.audioClip;

            sound.audioSource.volume = sound.volume;
            sound.audioSource.pitch = sound.pitch;

        }
        
    }


    public void Play(string name)
    {

        Sound sound = Array.Find(sounds, sound => sound.name == name);
        sound.audioSource.Play();

    }


}
