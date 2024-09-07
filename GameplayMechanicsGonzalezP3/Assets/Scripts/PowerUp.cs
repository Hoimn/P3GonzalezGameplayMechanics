using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PowerUpType {  None, Pushback, Rockets, Smash}

public class PowerUp : MonoBehaviour
{
    public float hangTime;
    public float smashSpeed; 
    public float explosionForce; 
    public float explosionRadius;
    bool smashing = false;
    float floorY;

    public PowerUpType powerUpType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
