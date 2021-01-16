﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] private Vector3[] points;
    private Vector3 _currentPosition;
    private bool _gameStarted;

    // Start is called before the first frame update
    void Start()
    {
        _gameStarted = true;
        _currentPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        if (!_gameStarted && transform.hasChanged)
        {
            _currentPosition = transform.position;
        }

        for (int i = 0; i < points.Length; i++)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(points[i]+ _currentPosition, 0.5f);

            if (i < points.Length - 1)
            {
                Gizmos.color = Color.gray;
                Gizmos.DrawLine(points[i], points[i + 1] + _currentPosition);
            }
        }
    }
}
