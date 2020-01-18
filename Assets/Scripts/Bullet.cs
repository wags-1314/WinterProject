﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public Vector2 direction = Vector2.zero;
    public float speed = 0;
    public bool isDeflected;

    void Start() {
        isDeflected = false;    
    }

    void FixedUpdate() {
        transform.Translate(direction.normalized * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "enemy" && isDeflected) {
            Destroy(other.gameObject);
        }
    }
}