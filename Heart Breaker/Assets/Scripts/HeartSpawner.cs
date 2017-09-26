using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSpawner : MonoBehaviour {

    public GameObject heart;
    public Transform[] spawnPoints;
    public float minDelay = .1f;
    public float maxDelay = 1f;
    // Use this for initialization
    void Start() {
        StartCoroutine(SpawnHeart());
    }
    IEnumerator SpawnHeart() {
        while (true) {

            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            GameObject spawnedHeart = Instantiate(heart, spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnedHeart, 5f);
        }
    }
}
