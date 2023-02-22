using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerTimedInteraction : MonoBehaviour
{
    [SerializeField] private InteractionHandler _interactionHandler;
    [SerializeField] private CharacterInteractionCounter _interactionCounter;
    private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip; 

    private bool startTimer; 
    
    private float timer;
    private float timerEnd;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>(); 
    }

    private void Update()
    {
        if (_interactionHandler._audio.Count == _interactionCounter.MyInteractions + 1)
        {
            startTimer = true;
        }
        else
        {
            startTimer = false;
        }

        
    }

    private void playAudio()
    {
        if (startTimer)
        {
            timer = Time.time;
        }

        if (startTimer && Time.time > (timer + timerEnd))
        {
            _audioSource.PlayOneShot(_audioClip);
            startTimer = false;
        }
    }
}
