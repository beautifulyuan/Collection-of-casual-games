using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objmoving : MonoBehaviour
{
    // Start is called before the first frame update

    
    public float speed;
    private Vector3 Tar;
    void Start()
    {
        speed = 3f;

        float x = Random.Range(-5,5);

        float y = this.GetComponent<Transform>().position.y;

         Tar = new Vector3(x, y, 0);



    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, Tar) > Mathf.Epsilon)

        {

            transform.position = Vector3.MoveTowards(transform.position, Tar, speed * Time.deltaTime);
        }
        else
        {
            float x = Random.Range(-5, 5);

            float y = this.GetComponent<Transform>().position.y;

             Tar = new Vector3(x, y, 0);



        }

    }


}
        
