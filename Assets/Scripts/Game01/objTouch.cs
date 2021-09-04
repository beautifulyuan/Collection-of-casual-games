using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class objTouch : MonoBehaviour
{
    public GameObject endpage;

    public float timer;

    public bool IsPointerOverGameObject(Vector2 screenPosition)
    {
        //ʵ��������¼�
        PointerEventData eventDataCurrentPosition = new PointerEventData(UnityEngine.EventSystems.EventSystem.current);
        //�����λ�õ���Ļ���긳ֵ������¼�
        eventDataCurrentPosition.position = new Vector2(screenPosition.x, screenPosition.y);

        List<RaycastResult> results = new List<RaycastResult>();
        //��������������
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
                endpage.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }


   
    /*  void OnMouseOver()
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
