using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlemovement : MonoBehaviour
{
    private Rigidbody2D circleRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        // get komponen
        circleRigidbody = GetComponent<Rigidbody2D>();

        // force
        circleRigidbody.AddForce(Vector2.one * 5, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
