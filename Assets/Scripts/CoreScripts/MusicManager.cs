using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource _audioSource;
    private CapsuleCollider _collider;

    [SerializeField] private List<AudioClip> _audioClips;

    private int musicInteger; 

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _collider = GetComponent<CapsuleCollider>();
        
        _audioSource.PlayOneShot(_audioClips[musicInteger]);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MusicBox") && musicInteger != 1)
        {
            musicInteger = 1;
            _audioSource.Stop();
            _audioSource.PlayOneShot(_audioClips[musicInteger]);
        }
    }
}
