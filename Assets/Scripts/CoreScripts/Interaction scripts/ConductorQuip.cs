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

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (otherCharacterLines.MyInteractions == QuipScrub.NeededInteraction && !_otherCharacterAudioSource.isPlaying)
        {
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}
