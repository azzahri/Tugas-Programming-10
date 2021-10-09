using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectdestroy : MonoBehaviour
{
    public Text scoreText;
    int score;

    public GameObject blood;

     void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.collider.CompareTag("Enemy"))
         {
            Destroy(collision.gameObject);
            score++;
            collision.gameObject.SetActive(false);

            Instantiate(blood, transform.position, Quaternion.identity);

         }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    
}
