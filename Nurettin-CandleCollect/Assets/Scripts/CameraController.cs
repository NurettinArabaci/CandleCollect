using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;
   
    
    private void LateUpdate()
    {
        
        Vector3 pos = new Vector3(player.position.x * 0.2f, player.position.y + 7.5f, player.position.z - 15);
        transform.position = pos;
    }
}
