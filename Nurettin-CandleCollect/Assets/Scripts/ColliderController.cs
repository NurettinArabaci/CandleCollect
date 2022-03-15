using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderController : MonoBehaviour
{

    public static int scoreAmount = 1;

    [SerializeField] Button restartButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Obstacle")
        { 
            TakeDamage();
            Destroy(other.gameObject);
        }
        else if (other.tag == "Collectable")
        {             
            CollectCandle();
            Destroy(other.gameObject);
            
        }

    }


    public void TakeDamage()
    {
        scoreAmount--;
        GameOver();

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

    public void GameOver()
    {
        if (scoreAmount<=0)
        {
            PlayerMovement.speed = 0;
            PlayerMovement.xSpeed = 0;

            restartButton.gameObject.SetActive(true);
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }


    
}
