using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehaviour : MonoBehaviour
{
    private Transform target;
    private float speed = 15.0f; 
    private bool homing; 
    private float rocketStrength = 15.0f; 
    private float aliveTimer = 5.0f;
    // Start is called before the first frame update
    public void Fire(Transform newTarget) 
    { 
        target = homingTarget; 
        homing = true;
        Destroy(gameObject, aliveTimer);
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}