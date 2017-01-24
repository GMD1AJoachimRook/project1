using UnityEngine;
using System.Collections;

public class Bumpscript : MonoBehaviour {
    public float force;

    public void OnCollisionEnter(Collision other){

        print("Points colliding: " + other.contacts.Length);
        print("First normal of the point that collide: " + other.contacts[0].normal);

        other.gameObject.GetComponent<Rigidbody>().AddForce(other.contacts[0].normal * force);
    }
        //zodra er contact is met de gameobject met dit script vliegt de sphere een kant op met de ingestelde force en vector
}