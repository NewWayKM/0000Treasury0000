using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickType2 : JoystickHandler
{


    [SerializeField] private PhysicCharacterMovement characterMovement;

    private void Update()
    {
        if (_inputVector.x != 0 || _inputVector.y != 0)
        {
            characterMovement.MoveCharacter(new Vector3(_inputVector.x, 0, _inputVector.y));
            characterMovement.RotateCharacter(new Vector3(_inputVector.x, 0, _inputVector.y));
        }
        else
        {
            characterMovement.MoveCharacter(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
            characterMovement.RotateCharacter(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
        }
    }
}
