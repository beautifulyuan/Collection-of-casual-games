using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rd_Move : MonoBehaviour
{

    public float speed;
    public float RotationAngle =25f;
    private Vector3 targetPos;
   
    float timer;
   
    public void Start()
    {
        
        timer = 0;
        float x = Random.Range(-6, 6);
        float y = Random.Range(-3, 3);
        targetPos = new Vector3(x, y, 0);

        speed = Rd_obj.level * 0.1f + 1f;

    }


    private void Update()
    {


       

        timer += Time.deltaTime;
        if (timer > 2 && timer < 12)
        {
            if (Vector3.Distance(transform.position, targetPos) > Mathf.Epsilon)

            {
                transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

                transform.rotation = Quaternion.AngleAxis((targetPos - transform.position).normalized.y * RotationAngle, Vector3.right);
            }
            else
            {

                float x = Random.Range(-6, 6);
                float y = Random.Range(-3, 3);
                targetPos = new Vector3(x, y, 0);
            }

         }

    }




   }



     
        


   
  
  

