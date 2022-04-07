using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
using DG.Tweening;

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
        //transform.GetComponent<Animator>().enabled = true;
        //transform.GetComponent<Animator>().SetBool("finish", true);
        transform.DOMove(new Vector3(0, 14.5f, 237f),1.4f);
        Invoke(nameof(EndMovement), 1.4f);
        vCamOne.GetComponent<CameraController>().enabled = false;
        vCamTwo.m_Priority = 11;
        
    }

    void EndMovement()
    {
        transform.DOMove(new Vector3(0, 13.8f, 240f), 0.6f);
    }
}
