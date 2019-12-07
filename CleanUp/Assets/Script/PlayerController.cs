﻿using UnityEngine;
 using System.Collections;
 
 // PlayerScript requires the GameObject to have a Rigidbody2D component
 
 [RequireComponent (typeof (Rigidbody2D))]
 
 public class PlayerController : MonoBehaviour {
     
 
     public float playerSpeed = 4f;
 
     void Start () {
     
     }
     
     void FixedUpdate () {
         Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
         GetComponent<Rigidbody2D>().velocity=targetVelocity * playerSpeed;
     }
 }