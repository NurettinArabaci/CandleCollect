using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{
    public CinemachineVirtualCameraBase vCamOne;
    public CinemachineVirtualCameraBase vCamTwo;
    public GameObject particleSys;

    Button completedButton;

    private void Start()
    {
        completedButton = GameManager.nextLevelBut;
        vCamTwo.m_Priority = 9;
    }


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
            particleSys.SetActive(true);
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
