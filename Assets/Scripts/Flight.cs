using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    [SerializeField] private float speed = 0;

    void Update()
    {
        Move();
    }

    protected void Move()
    {

        float up = 0f;
        float down = 0f;
        float left = 0f;
        float right = 0f;

        if (IsUp()){
            up = speed;
        }

        if (IsDown()){
            down = speed;
        }

        if (IsLeft()){
            left = speed;
        }

        if (IsRight()){
            right = speed;
        }

        Vector3 targetPosition = new(right - left, speed, up - down);

        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);
        //float step = speed * Time.deltaTime;
        //transform.position = Vector3.Lerp(transform.position, transform.position + targetPosition, step);
    }

    private bool IsUp(){
        return Input.GetKey(KeyCode.UpArrow);
    }

    private bool IsDown(){
        return Input.GetKey(KeyCode.DownArrow);
    }

    private bool IsLeft(){
        return Input.GetKey(KeyCode.LeftArrow);
    }
    
    private bool IsRight(){
        return Input.GetKey(KeyCode.RightArrow);
    }

}
