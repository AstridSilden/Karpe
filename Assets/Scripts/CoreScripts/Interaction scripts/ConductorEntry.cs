using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConductorEntry : MonoBehaviour
{
    [SerializeField] private AudioSource _conductorAudio;
    [SerializeField] private AudioClip _audioClip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _conductorAudio.PlayOneShot(_audioClip);
        }
    }
}
