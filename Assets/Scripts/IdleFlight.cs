using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleFlight : MonoBehaviour
{
    
    [SerializeField] private float xSpeed = 0f;
    [SerializeField] private float ySpeed = 0f;
    [SerializeField] private float zSpeed = 0f;

    [SerializeField] private float xDistance = 0f;
    [SerializeField] private float yDistance = 0f;
    [SerializeField] private float zDistance = 0f;

    [SerializeField] private float rotationAngle = 0f;
    [SerializeField] private float rotationSpeed = 0f;

    private Vector3 initialPosition;
    private readonly float initialRotation;

    void Start()
    {
        if (gameObject != null)
        {
            initialPosition = transform.position;
        }
    }

    void Update()
    {
        if (gameObject != null)
        {
            float xOffset = Mathf.Sin(Time.time * xSpeed) * xDistance;
            float yOffset = Mathf.Sin(Time.time * ySpeed) * yDistance;
            float zOffset = Mathf.Sin(Time.time * zSpeed) * zDistance;
            Vector3 newPosition = initialPosition + new Vector3(xOffset, yOffset, zOffset);
            transform.position = newPosition;

            float rotationOffset = Mathf.Sin(Time.time * rotationSpeed) * rotationAngle;
            float newRotation = initialRotation + rotationOffset;
            transform.rotation = Quaternion.Euler(0f, 0f, newRotation);
        }
    }
    
}
