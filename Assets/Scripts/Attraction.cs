using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attraction : MonoBehaviour
{
    public GameObject sphere;
    public float force = 5f;
    private Vector3 directionSphere;
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        directionSphere = sphere.transform.position - transform.position;
        rb.AddForce(directionSphere.normalized * force);
    } 
}
