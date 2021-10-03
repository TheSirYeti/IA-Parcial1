using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekingAgent : MonoBehaviour
{
    public GameObject target;

    private Vector3 _velocity;
    public float maxSpeed;
    public float maxForce;


    public Vector3 GetVelocity()
    {
        return _velocity;
    }

    void Update()
    {
        //Seek();

        //transform.position += _velocity * Time.deltaTime;
        //transform.forward = _velocity.normalized;
    }


    void Seek()
    {
        Vector3 desired = target.transform.position - transform.position;
        desired.Normalize();
        desired *= maxSpeed;

        Vector3 steering = desired - _velocity;
        steering = Vector3.ClampMagnitude(steering, maxForce);

        ApplyForce(steering);

    }

    void ApplyForce(Vector3 force)
    {
        _velocity += force;
    }
    
    
}

