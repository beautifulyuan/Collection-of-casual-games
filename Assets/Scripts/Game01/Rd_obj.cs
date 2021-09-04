using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Rd_obj : MonoBehaviour
{

    public GameObject obj;
    public GameObject player;
    float timer;
    public static int level ;
   
    public Text leveltext;
   
    


    // Start is called before the first frame update
    void Start()
    {

        timer = 0;
        level++;
        float num = level / 3 + 1;
        player.SetActive(true);
        obj.SetActive(true);
        //Éú³É

        player.GetComponent<Renderer>().material.color = Color.red;
        for (int i = 0; i < num; i++)

        {

            Instantiate(obj, new Vector3(Random.Range(-6f, 6f), Random.Range(-3f, 3f), 1), Quaternion.identity);

        }

   

    }
     void Update()
    {

        int zero = level / 2;
        leveltext.text = " level " + zero.ToString("");
       

        timer += Time.deltaTime;
        if (timer > 2 && timer < 3)
        {
            
            player.GetComponent<Renderer>().material.color = Color.white;

        }


    }






    


}