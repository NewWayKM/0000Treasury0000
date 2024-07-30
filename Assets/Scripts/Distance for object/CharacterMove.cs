using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    [Header("Character movement stats")]
    [SerializeField] private float _moveSpeed;

    private CharacterController _characterController;

    private Vector3 _moveDirection;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    public void MoveCharacter(Vector3 moveDirection)
    {
        _moveDirection = moveDirection;

        _characterController.Move(moveDirection * Time.deltaTime * _moveSpeed);
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, _moveDirection);
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(Vector3.zero, _moveDirection + transform.position);
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(Vector3.zero, transform.position);
    }
}
