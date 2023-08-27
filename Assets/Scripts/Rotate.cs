using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField] private int velocityX = 0;
    [SerializeField] private int velocityY = 0;
    [SerializeField] private int velocityZ = 0;

    void Update()
    {
        float deltaX = velocityX * Time.deltaTime;
        float deltaY = velocityY * Time.deltaTime;
        float deltaZ = velocityZ * Time.deltaTime;

        Vector3 rotationVector = new(deltaX, deltaY, deltaZ);

        transform.Rotate(rotationVector);
    }
}
