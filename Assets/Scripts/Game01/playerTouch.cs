
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System;

public class playerTouch : MonoBehaviour
{
    public GameObject nextpage;

    public GameObject Winpage;

    float timer;

    public bool IsPointerOverGameObject(Vector2 screenPosition)
    {
        //实例化点击事件
        PointerEventData eventDataCurrentPosition = new PointerEventData(UnityEngine.EventSystems.EventSystem.current);
        //将点击位置的屏幕坐标赋值给点击事件
        eventDataCurrentPosition.position = new Vector2(screenPosition.x, screenPosition.y);

        List<RaycastResult> results = new List<RaycastResult>();
        //向点击处发射射线
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);

        return results.Count > 0;
    }
     void Start()
    {
        timer = 0;

    }
    void Update()
    {
        timer += Time.deltaTime;
        
    }
    void OnMouseDown()
    {
        
        if (timer > 12)
        {
            if (!IsPointerOverGameObject(Input.mousePosition))
            {


                this.GetComponent<Renderer>().material.color = Color.red;
                if (Rd_obj.level / 2 < 12)
                {
                    nextpage.SetActive(true);
                    Time.timeScale = 0;
                }
                else
                {
                    Winpage.SetActive(true);
                    Time.timeScale = 0f;
                }
            }

        }
;
    }

    /*
  
    void OnMouseOver()
    {
        if (!IsPointerOverGameObject(Input.mousePosition))
        {
            this.GetComponent<Renderer>().material.color = Color.red;
        }



    }

    void OnMouseExit()
    {
        if (!IsPointerOverGameObject(Input.mousePosition))
        {
            this.GetComponent<Renderer>().material.color = Color.white;
        }

    }
    */
  


}
