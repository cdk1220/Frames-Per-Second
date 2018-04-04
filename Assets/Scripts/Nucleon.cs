using UnityEngine;

/* A Rigidbody component will always be added to the gameobject which this script
 * is attached to */

[RequireComponent(typeof(Rigidbody))]
public class Nucleon : MonoBehaviour {
    public float attractionForce;

    Rigidbody body;

    void Awake() {
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        
        /* By inverting the position vector of the gameobject with respect to the origin
         * and applying after desired scaling makes the object shoot to the center of the
         * screen */
        body.AddForce(transform.localPosition * -attractionForce);
    }
}