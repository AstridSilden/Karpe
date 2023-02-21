using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "CharacterInteractions", menuName = "CharacterInteractionsLocal")]

public class CharacterInteractionCounter : ScriptableObject
{
    public int MyInteractions;

    public void Start()
    {
        MyInteractions = -1;
    }

    public void OnInteraction()
    {
        MyInteractions++;
    }
}
