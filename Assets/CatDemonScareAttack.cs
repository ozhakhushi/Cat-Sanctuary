using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDemonScareAttack : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 targetPoint;
    public float velocity;
    public float smoothTime;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
/*
    // Update is called once per frame
    void FixedUpdate()
    {
         // Get the delta position  
  Vector3 dir = targetPoint - rb.position;
  // Get the velocity required to reach the target in the next frame
  dir /= Time.fixedDeltaTime;
  // Clamp that to the max speed
  dir = Vector3.ClampMagnitude(dir, velocity);
  // Apply that to the rigidbody
  rb.velocity = dir;

    } */

    // The target marker.
    public Transform target;

    // Angular speed in radians per sec.
    public float speed = 5.0f;

    void Update()
    {
        // Determine which direction to rotate towards
        Vector3 targetDirection = target.position - transform.position;

        // The step size is equal to speed times frame time.
        float singleStep = speed * Time.deltaTime;

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        // Draw a ray pointing at our target in
        Debug.DrawRay(transform.position, newDirection, Color.red);

        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.LookRotation(newDirection);
        rb.velocity = newDirection;

    }
}
