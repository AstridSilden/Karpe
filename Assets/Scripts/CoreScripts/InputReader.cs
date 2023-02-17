using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public Vector2 MoveVector { get; private set; }
    public Vector2 LookVector { get; private set; }
   
    public bool CrouchButton { get; private set; }
    public bool InteractButton { get; private set; }

    private PlayerInputs _playerInputs; 

    #region Instanciate

    private void Awake()
    {
        _playerInputs = new PlayerInputs();
    }

    private void OnEnable()
    {
        _playerInputs.Enable();
    }

    private void OnDisable()
    {
        _playerInputs.Disable();
    }

    #endregion


    #region SetInputs

    private void Update()
    {
        MoveVector = _playerInputs.PlayerActions.PlayerMovement.ReadValue<Vector2>();
        LookVector = _playerInputs.PlayerActions.MouseInput.ReadValue<Vector2>(); 

        CrouchButton = _playerInputs.PlayerActions.Crouch.triggered;
        InteractButton = _playerInputs.PlayerActions.Interact.triggered;
    }

    #endregion
}
