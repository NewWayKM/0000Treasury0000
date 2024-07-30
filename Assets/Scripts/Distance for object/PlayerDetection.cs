using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDetection : MonoBehaviour
{
    [SerializeField] private GameObject _player; // ссылка для игрока

    [SerializeField] private float _minimalDistanceForDetected = 10;
    private float _distanceToPlyaer;

    private Vector3 _enemyPosition;
    private Vector3 _directionToPlayer;

    [SerializeField] private TMP_Text distanceDisplay;

    private void Start()
    {
        _enemyPosition = transform.position;
    }

    private void Update()
    {
        _directionToPlayer = _player.transform.position - _enemyPosition; // вычитаие векторов
        _distanceToPlyaer = _directionToPlayer.magnitude; // модуль вектора

        distanceDisplay.text = _distanceToPlyaer.ToString("0.0") + "m";

        if (_distanceToPlyaer < _minimalDistanceForDetected)
        {
            distanceDisplay.color = Color.red;
            Debug.DrawLine(_enemyPosition, _player.transform.position, Color.red);
        }
        else
        {
            distanceDisplay.color = new Color(1, 0.7469491f, 0);
            Debug.DrawLine(_enemyPosition, _player.transform.position, Color.cyan);
        }
    }

}
