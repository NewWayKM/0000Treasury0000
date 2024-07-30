using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePlayer : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    [SerializeField] private float _minimalDistanceForDetected = 10;
    private float _distanceToPlyaer;

    private Vector3 _enemyPosition;
    private Vector3 _directionToPlayer;

    [SerializeField] private float _moveSpeed;

    // Start is called before the first frame update
    private void Start()
    {
        _enemyPosition = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        _directionToPlayer = _player.transform.position - _enemyPosition;
        _distanceToPlyaer = _directionToPlayer.magnitude;

        if (_distanceToPlyaer < _minimalDistanceForDetected)
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _moveSpeed * Time.deltaTime);
        }
    }
}
