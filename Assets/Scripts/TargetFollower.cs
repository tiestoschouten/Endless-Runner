﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollower : MonoBehaviour 
{
    [SerializeField]
    private Transform _target;

    private Vector3 _offset;

	private void Start()
	{
        _offset = _target.position - transform.position;
	}

	private void Update()
	{
        transform.position = _target.position - _offset;
	}
}
