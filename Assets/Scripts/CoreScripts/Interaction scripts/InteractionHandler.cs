using System;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    public CharacterInteractionCounter _interactionCounter;
    private AudioSource _audioSource;
    [SerializeField] private List<AudioClip> _audio;
    [SerializeField] private AudioSource _secondaryCharacter; 

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _interactionCounter.MyInteractions = -1;
        
    }


    public void InteractedWith()
    {
        if (!_audioSource.isPlaying && !_secondaryCharacter.isPlaying)
        {
            if (_interactionCounter.MyInteractions < (_audio.Count - 1))
            {
                _interactionCounter.MyInteractions++; 
                
                _audioSource.PlayOneShot(_audio[_interactionCounter.MyInteractions]);
            }
            else
            {
                _audioSource.PlayOneShot(_audio[_interactionCounter.MyInteractions]);
            }
        }
    }
}
