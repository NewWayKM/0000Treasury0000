using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputForMovement : MonoBehaviour
{
    [SerializeField] private CharacterMove _characterMove;

    private float _horizontal;
    private float _vertical;

    private void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");

        _characterMove.MoveCharacter(new Vector3(_horizontal, 0, _vertical).normalized);
    }
}
