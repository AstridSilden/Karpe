using System;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    public CharacterInteractionCounter _interactionCounter;
    private AudioSource _audioSource;
    private int myInteraction_Min = -1;
    private int myInteraction_Max; 
    [SerializeField] private List<AudioClip> _audio;
    [SerializeField] private AudioSource _secondaryCharacter; 

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _interactionCounter.MyInteractions = -1;
        
    }

    private void Update()
    {
        myInteraction_Max = _audio.Count;
        print("audio amount" + _audio.Count);
    }


    public void InteractedWith()
    {
        if (!_audioSource.isPlaying && !_secondaryCharacter.isPlaying)
        {
            print("Neither audio source is playing");
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
