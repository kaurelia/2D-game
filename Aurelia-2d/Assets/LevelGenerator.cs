using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
    public GameObject platformPrefab;
    public int numberOfPlatforms = 100;
    public float levelWidth = 3f;
    public float minY = 1.5f;
    public float maxY = 4.5f;
    void Start() {
        Vector3 spawnPostion = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++) {
            spawnPostion.y += Random.Range(minY, maxY);
            spawnPostion.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPostion, Quaternion.identity);

        }
    }
    void Update() {
        
    }
}
