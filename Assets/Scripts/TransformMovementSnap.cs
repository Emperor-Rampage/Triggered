﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class TransformMovementSnap : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.position += Vector3.right;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.position += Vector3.left;

        if (Input.GetKeyDown(KeyCode.UpArrow))
            transform.position += Vector3.forward;

        if (Input.GetKeyDown(KeyCode.DownArrow))
            transform.position += Vector3.back;

        if (Input.GetKeyDown(KeyCode.Space))
            transform.position = new Vector3(0, 1f, 0);
    }
}
