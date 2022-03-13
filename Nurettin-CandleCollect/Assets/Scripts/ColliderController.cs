using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{

    public static int scoreAmount = 1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Obstacle")
        {
            scoreAmount--;
            Debug.Log(scoreAmount);
            TakeDamage();
        }
        else if (other.tag == "Collactable")
        {
            scoreAmount++;
            Debug.Log(scoreAmount);
            CollectCandle();
        }
    }


    public void TakeDamage()
    {
        transform.GetChild(scoreAmount).gameObject.SetActive(false);
    }

    public void CollectCandle()
    {
        transform.GetChild(scoreAmount-1).gameObject.SetActive(true);
    }
}
