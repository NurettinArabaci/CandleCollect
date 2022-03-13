using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            GameEnd();
        }
        else if (other.tag == "Cake")
        {
            transform.GetComponent<Animator>().enabled = false;
            PlayerMovement.speed = 0;
            PlayerMovement.xSpeed = 0;

        }
    }
    public void GameEnd()
    {
        transform.GetComponent<Animator>().enabled = true;
        transform.GetComponent<Animator>().SetBool("finish", true);

        Debug.Log("Level Completed");
    }
}
