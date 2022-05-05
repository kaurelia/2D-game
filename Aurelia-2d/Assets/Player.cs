using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
    public float movementSpeed = 10f;
    float movement = 0f;
    Rigidbody2D rigidbody;
    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();  
    }
    void Update() {
        movement = Input.GetAxis("Horizontal") * movementSpeed; 
    }
    void FixedUpdate() {
        Vector2 velocity = rigidbody.velocity;
        velocity.x = movement;
        rigidbody.velocity = velocity;
    }
}
