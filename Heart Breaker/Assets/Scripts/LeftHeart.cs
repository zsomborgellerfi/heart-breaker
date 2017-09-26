using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHeart : MonoBehaviour {

    public float thrust = 10f;

    void Start() {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.left * thrust, ForceMode2D.Impulse);
    }
}
