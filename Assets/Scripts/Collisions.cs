using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

    public float force = 500f;
    [SerializeField] private GameObject obj;
    private Vector3 directionOfImpact;
    private Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    

    private void OnCollisionEnter (Collision collision)
    {
        directionOfImpact = -1 * (obj.transform.position - transform.position);        
        rb.AddForce(directionOfImpact.normalized * force);       
    }
}