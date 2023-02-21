using System;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    public CharacterInteractionCounter _interactionCounter;
    private AudioSource _audioSource;
    [SerializeField] private List<AudioClip> _audio;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>(); 
    }


    public void InteractedWith()
    {
        if (!_audioSource.isPlaying)
        {
            if (_interactionCounter.MyInteractions < _audio.Count)
            {
                _interactionCounter.OnInteraction();
            }
            _audioSource.PlayOneShot(_audio[_interactionCounter.MyInteractions]);
        }
    }
}
