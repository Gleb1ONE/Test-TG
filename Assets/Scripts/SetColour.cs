using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColour : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
     {
        Transform child = collision.GetContact(0).thisCollider.transform;
        child.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }
}
