using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mover : MonoBehaviour
{
    public float MoveSpeed;
    public float jumpForce;
    private CharacterController controller;

    private Vector2 moveDirection = Vector2.zero;
    private Vector2 inputVector = Vector2.zero;
    private Rigidbody2D rb;

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void SetInputVector(Vector2 direction)
    {
        inputVector = direction;
    }

    // Update is called once per frame
    void Update()
    {
       
        moveDirection = new Vector2(inputVector.x , 0);
        moveDirection = transform.TransformDirection(moveDirection * MoveSpeed);
        Debug.Log(moveDirection);
        Debug.Log(inputVector.x);
        rb.velocity = moveDirection * Time.deltaTime;
        
       //transform.Translate(moveDirection * Time.deltaTime);

        

    }
}
