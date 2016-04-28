using UnityEngine;
using System.Collections;

public class SugarHit : MonoBehaviour {

    public ToothManager skull;

    void Start()
    {
        skull = GameObject.FindGameObjectWithTag("Skull").GetComponent<ToothManager>();

        // Destroy the game object after 2 seconds.
        Destroy(gameObject, 3.0f);
    }

    public void OnCollisionEnter(Collision collision)
    {
        GameObject otherGO = collision.collider.gameObject;
        if (otherGO.tag != "Teeth")
        {
            skull.TakeDamage();
        }
    }
}
