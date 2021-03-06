using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlemovement : MonoBehaviour
{
    private Rigidbody2D circleRigidbody;
    public float speed = 5f;
    private Vector3 targetPosition;
    private bool isMoving = false;


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

        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        if(isMoving)
        {
            Move();
        }
    }

    void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;

        isMoving = true;
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if(transform.position == targetPosition)
        {
            isMoving = false;
        }
    }
}
