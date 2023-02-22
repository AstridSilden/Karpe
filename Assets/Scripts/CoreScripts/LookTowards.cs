using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTowards : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private void Update()
    {
        transform.LookAt(_playerTransform);
    }
}
