using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {
    
    bool isTouching = false;
    Rigidbody2D rb;
    Camera cam;
    CircleCollider2D circleCollider;

    void Start() {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
    }
    // Update is called once per frame

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            isTouching = true;
            circleCollider.enabled = true;
        } else if (Input.GetMouseButtonUp(0)) {
            isTouching = false;
            circleCollider.enabled = false;
        }
        if (isTouching) {
            UpdateTouchPosition();
        }
    }
    void UpdateTouchPosition() {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;
    }
    
}
