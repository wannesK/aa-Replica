﻿using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed = 100f;

    void Update()
    {
        Rotate();
    }
    private void Rotate()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}
