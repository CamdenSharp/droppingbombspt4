using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovementTwo : MonoBehaviour
{

    [Header("Movement")]
    [Tooltip("Speed of movement")]
    public float speed;
    public enum MovementType
    {
        
        VerticalOnly
    }

    [SerializeField]
    private MovementType movementType = 0;

    [Header("Platform Movement")]
    [Tooltip("Adjusts Movement for Platform Games")]
    public bool platformSettings = false;

    private float masterSpeed;




    void Awake()
    {
        masterSpeed = speed;
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical");

        if (platformSettings)
        {
            Rigidbody2D rigidBody;
            rigidBody = GetComponent<Rigidbody2D>();
            float verticalMovement = rigidBody.velocity.y;
            if (verticalMovement != 0)
            {
                speed = masterSpeed / 3;
            }
            else
            {
                speed = masterSpeed;
            }
        }

        switch (movementType)
        {
            case MovementType.VerticalOnly:
                vertical = 0f;
                break;
        }

        Vector3 movement = new Vector2(vertical, vertical);

        transform.position += movement * Time.deltaTime * speed;
    }

}