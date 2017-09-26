using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour {

    public GameObject brokenHeartPrefab;
    public float minHeartSize = 0.1f;
    public float maxHeartSize = 0.2f;
    float heartSize;

    void Start() {
        heartSize = Random.Range(minHeartSize, maxHeartSize);    
        transform.localScale = new Vector2(heartSize, heartSize);
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "Touch") {
            GameObject brokenHeart = Instantiate(brokenHeartPrefab, transform.position, Quaternion.identity);
            brokenHeart.transform.localScale = transform.localScale;
            Destroy(brokenHeart, 4f);
            Destroy(gameObject);
        }
    }
}
