using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollwPlayer : MonoBehaviour
{
    public Transform Player;
    
    
    void Update()
    {
        transform.position = new Vector3(0, Player.position.y + 2,-10);
    }
}
