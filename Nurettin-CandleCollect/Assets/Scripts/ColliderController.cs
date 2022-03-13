using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{

    int scoreAmount = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Obstacle")
        {
            scoreAmount--;
            Debug.Log(scoreAmount);
        }
    }
}
