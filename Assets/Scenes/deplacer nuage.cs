using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacerNuage : MonoBehaviour
{
    public float vitesse;

    // Start is called before the first frame update
    void Start() {
        vitesse = 0.03f
    }

    // Update is called once per frame
    void Update() {
        if (transform.position.x > 15) {
            transform.position = new Vector2(-18,0);
        }
        transform.Translate(vitesse,0,0);
    }
}
