using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
    [SerializeField] private Transform _originPoint;
    [SerializeField] private GameObject conductor; 
    private InputReader _input;

    private void Start()
    {
        _input = GetComponent<InputReader>();
    }
    private void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(_originPoint.position, _originPoint.forward, out hit, 9))
        {
            if (hit.collider.CompareTag("Interactable"))
            {
                if (!_input.InteractButton)
                {
                    return;
                }

                {
                    var handler = hit.collider.gameObject.GetComponent<InteractionHandler>();
                    if (handler != null) handler.InteractedWith();
                }
            }
        }
    }
}
