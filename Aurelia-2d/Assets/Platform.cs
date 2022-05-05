using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platform : MonoBehaviour {
    public float jumpForce = 10f;
    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.relativeVelocity.y <= 0f) {
            Rigidbody2D rigidBody = collision.collider.GetComponent<Rigidbody2D>();
            if (rigidBody != null) {
                Vector2 velocity = rigidBody.velocity;
                velocity.y = jumpForce;
                rigidBody.velocity = velocity;
            }
        }
    }
}
