using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlemovement : MonoBehaviour
{
    private Rigidbody2D circleRigidbody;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        // get komponen
        circleRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        transform.Translate(Vector2.up * Input.GetAxis("Vertical") * Time.deltaTime * speed);
    }


}
