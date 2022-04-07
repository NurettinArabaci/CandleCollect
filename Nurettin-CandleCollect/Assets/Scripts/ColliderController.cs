using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ColliderController : MonoBehaviour
{

    public static int scoreAmount = 1;

    Button restartButton;

    private void Start()
    {
        scoreAmount = 1;
        restartButton = GameManager.restartBut;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Obstacle")
        {
            TakeDamage();
            other.gameObject.tag = "Untagged";
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

        transform.GetChild(0).DOMoveY(transform.GetChild(0).transform.position.y - 0.8f, 0.5f);
        transform.GetChild(1).DOScaleY(transform.GetChild(1).transform.localScale.y - 1, 0.5f);
    }

    public void CollectCandle()
    {
        if (scoreAmount<11)
        {
            scoreAmount++;
            transform.GetChild(1).DOScaleY(transform.GetChild(1).transform.localScale.y+ 1, 0.5f);
            transform.GetChild(0).DOMoveY(transform.GetChild(0).transform.position.y+0.8f, 0.5f);
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
