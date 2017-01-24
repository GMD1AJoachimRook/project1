using UnityEngine;
using System.Collections;

public class Stap3 : MonoBehaviour {
    // zodra je de knop loslaat zal er force toegepast worden op de bal.

    public float powerUp;
    public float powerUpMax = 1.5f;
    public bool pressed = false;

    // dit is de maximale kracht waarmee de bal weggeschoten mag worden.
    public int maxForce = 1000;

    public Vector3 force = new Vector3(-1,0,0);
    public Rigidbody ball;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            powerUp = 0;
            pressed = true;
        }
        if (Input.GetButtonUp("Jump"))
        {
            pressed = false;
            // We schieten de bal weg met AddForce. De kracht is afhankelijk van hoe hard we de bal wegschieten en onze maximum force.
            ball.AddForce(force * powerUp * maxForce);
        }  
        if (pressed == true && powerUp < powerUpMax)
        {
            powerUp = powerUp + Time.deltaTime;
        }
    }
}
