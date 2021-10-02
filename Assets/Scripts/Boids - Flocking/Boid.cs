using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour
{
    /*private Vector3 _velocity;
    public float maxSpeed;
    public float maxForce;

    public float viewDistance;
    public float separationDistance;

    public float separationWeight;
    public float cohesionWeight;
    public float alignWeight;

    void Start()
    {
        BoidManager.instance.AddBoid(this);

        Vector3 randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
        randomDirection.Normalize();
        randomDirection *= maxSpeed;

        ApplyForce(randomDirection);
    }

    // Update is called once per frame
    void Update()
    {
        CheckBounds();
        
        ApplyForce(Align() * alignWeight); 
        ApplyForce(Cohesion() * cohesionWeight);
        ApplyForce(Separation() * separationWeight + Align() * alignWeight + Cohesion() * cohesionWeight);

        _velocity.y = 0;
        transform.position += _velocity * Time.deltaTime;
        transform.forward = _velocity;
    }

    Vector3 Cohesion()
    {
        Vector3 desired = new Vector3();
        int nearbyBoids = 0;

        foreach (var boid in BoidManager.instance.allBoids)
        {
            if (boid != this && Vector3.Distance(boid.transform.position, transform.position) < viewDistance)
            {
                desired += boid.transform.position;
                nearbyBoids++;
            }
        }
        if (nearbyBoids == 0) return desired;
        desired /= nearbyBoids;
        desired = desired - transform.position;
        desired.Normalize();
        desired *= maxSpeed;

        Vector3 steering = desired - _velocity;
        steering = Vector3.ClampMagnitude(steering, maxForce);
        return steering;
    }


    Vector3 Align()
    {
        Vector3 desired = new Vector3();
        int nearbyBoids = 0;
        foreach (var boid in BoidManager.instance.allBoids)
        {
            if (boid != this && Vector3.Distance(boid.transform.position, transform.position) < viewDistance)
            {
                desired += boid._velocity;
                nearbyBoids++;
            }
        }
        if (nearbyBoids == 0) 
            return Vector3.zero;
        
        desired = desired / nearbyBoids;
        desired.Normalize();
        desired *= maxSpeed;

        Vector3 steering = Vector3.ClampMagnitude(desired - _velocity, maxForce);

        return steering;
    }


    Vector3 Separation()
    {
        Vector3 desired = new Vector3();
        int nearbyBoids = 0;

        foreach (var item in BoidManager.instance.allBoids)
        {
            Vector3 dist = item.transform.position - transform.position;

            if (item != this && dist.magnitude < separationDistance)
            {
                //desired += dist;
                desired.x += dist.x;
                desired.z += dist.z;
                nearbyBoids++;
            }
        }
        if (nearbyBoids == 0) return desired;
        desired /= nearbyBoids;
        desired.Normalize();
        desired *= maxSpeed;
        desired = -desired;

        Vector3 steering = desired - _velocity;
        steering = Vector3.ClampMagnitude(steering, maxForce);
        //steering.y = 0;
        return steering;
    }

    
    
    
    
    
    void ApplyForce(Vector3 force)
    {
        _velocity += force;
        _velocity = Vector3.ClampMagnitude(_velocity, maxSpeed);

    }

    void CheckBounds()
    {
        if (transform.position.z > 15) transform.position = new Vector3(transform.position.x, transform.position.y, -15);
        if (transform.position.z < -15) transform.position = new Vector3(transform.position.x, transform.position.y, 15);
        if (transform.position.x < -26.5f) transform.position = new Vector3(26.5f, transform.position.y, transform.position.z);
        if (transform.position.x > 26.5f) transform.position = new Vector3(-26.5f, transform.position.y, transform.position.z);
    }*/
}
