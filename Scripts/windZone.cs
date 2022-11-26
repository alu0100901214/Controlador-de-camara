using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windZone : MonoBehaviour
{

    public float windForce;

    private void OnTriggerStay2D(Collider2D other) {
        other.GetComponent<Rigidbody2D>().AddForce( new Vector2(windForce,0f));
    }
}
