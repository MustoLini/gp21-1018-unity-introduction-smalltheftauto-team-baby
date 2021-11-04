using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MiniMapCameraFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;
    void Start()
    {
        transform.position = Player.position + offset;

        Vector3 rot = new Vector3(90, Player.eulerAngles.y, 0);
        
        transform.rotation = Quaternion.Euler(rot); 
    }

    
}
