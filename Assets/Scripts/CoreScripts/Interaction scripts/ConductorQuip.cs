using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConductorQuip : MonoBehaviour
{
    [SerializeField] private CharacterInteractionCounter otherCharacterLines;
    [SerializeField] private AudioSource _otherCharacterAudioSource;
    [SerializeField] private ConductorQuipScrub QuipScrub;
    [SerializeField] private AudioClip _audioClip;
    private AudioSource _audioSource;
    private bool canTalk; 

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        canTalk = true; 
    }

    private void Update()
    {
        if (otherCharacterLines.MyInteractions == QuipScrub.NeededInteraction && !_otherCharacterAudioSource.isPlaying)
        {
            if (!canTalk)
            {
                return;
            }
            _audioSource.clip = _audioClip;
            _audioSource.Play();
            canTalk = false; 
        }
    }
}
