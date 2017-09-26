using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHeart : MonoBehaviour {
    public float thrust = 10f;

    void Start() {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * thrust, ForceMode2D.Impulse);
    }
    void Update() {
        float minRotation = -720;
        float maxRotation = 720;
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.y = Mathf.Clamp(currentRotation.y, minRotation, maxRotation);
        transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
