using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{
    public CinemachineVirtualCameraBase vCamOne;
    public CinemachineVirtualCameraBase vCamTwo;

    public Button startButton;
    public Button failedButton;
    public Button completedButton;
    

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
            completedButton.gameObject.SetActive(true);


        }
    }
    public void GameEnd()
    {
        transform.GetComponent<Animator>().enabled = true;
        transform.GetComponent<Animator>().SetBool("finish", true);
        vCamOne.GetComponent<CameraController>().enabled = false;
        vCamTwo.m_Priority = 11;
        
    }
}
