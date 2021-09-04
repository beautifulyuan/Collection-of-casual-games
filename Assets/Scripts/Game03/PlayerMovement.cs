using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject overpage;
    public float forwardforce ;
    public float speed = 800f;
    public GameObject endpage;
    float timer;


    // Update is called once per frame


    private void Start()
    {
       timer = 0;
    }
    void FixedUpdate()
    {
        Vector2 dir = Vector2.zero;

        
        dir.x = Input.acceleration.x;

        timer += Time.deltaTime;

        if(timer < 2)
        {

            forwardforce = 100f;

        }
        else
        {
            forwardforce = 0;
        }


        rb.AddForce(Vector2.up * forwardforce * Time.deltaTime);

        rb.AddForce(dir* speed * Time.deltaTime);

        //¼üÅÌ ad¿ØÖÆ×óÓÒ
        /*if (Input.GetKey("d"))
        {
            rb.AddForce(Vector2.right * speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector2.left * speed * Time.deltaTime);
        }*/


    }

 


    public void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            
            overpage.SetActive(true);
            Time.timeScale = 0f;
        }

        if (collision.gameObject.tag == "end")
        {
            Destroy(collision.gameObject);
            endpage.SetActive(true);
            Time.timeScale = 0f;
        }

    }
}
