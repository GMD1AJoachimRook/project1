using UnityEngine;
using System.Collections;

public class FlipperRechtsBewegen : MonoBehaviour
{

    public float amount = 500000f;
    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightShift))
            {
            GetComponent<Rigidbody>().AddTorque(transform.forward * amount * Time.deltaTime, ForceMode.Impulse);
        }
        else
        {
            GetComponent<Rigidbody>().AddTorque(transform.forward * -amount * Time.deltaTime, ForceMode.Impulse);
        }
    }       //als je de rechter shifttoets ingedrukt houdt, dan gaat de flipper omhoog.
            // als je het los laat, gaat hij weer terug naar de startpositie
}
