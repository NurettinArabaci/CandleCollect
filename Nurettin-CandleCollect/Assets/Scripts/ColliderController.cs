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
            TakeDamage();
            Destroy(other.gameObject);
        }
        else if (other.tag == "Collactable")
        {             
            CollectCandle();
            Destroy(other.gameObject);
        }
        else if (other.tag == "ObstacleGround")
        {
            TakeDamage();
            other.transform.GetComponent<BoxCollider>().isTrigger = false; // tekrar çarpma kontrolu
        }
    }


    public void TakeDamage()
    {
        scoreAmount--;
        SpeedControl();

        transform.GetChild(scoreAmount+1).gameObject.SetActive(false);
        transform.GetChild(0).transform.position -= new Vector3(0, 0.8f, 0);

        Debug.Log(scoreAmount);
    }

    public void CollectCandle()
    {
        if (scoreAmount<11)
        {
            scoreAmount++;
            transform.GetChild(scoreAmount).gameObject.SetActive(true);
            transform.GetChild(0).transform.position += new Vector3(0, 0.8f, 0);

           
        }
        Debug.Log(scoreAmount);


    }

    public void SpeedControl()
    {
        if (scoreAmount<=0)
        {
            PlayerMovement.speed = 0;
            PlayerMovement.xSpeed = 0;
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
