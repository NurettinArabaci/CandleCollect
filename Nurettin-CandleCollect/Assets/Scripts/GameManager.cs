using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Button playBut;
    Button restartBut;
    Button nextLevelBut;

    private void Awake()
    {
        playBut = transform.GetChild(0).GetComponent<Button>();
        restartBut = transform.GetChild(1).GetComponent<Button>();
        nextLevelBut = transform.GetChild(2).GetComponent<Button>();
    }

    public void PlayButton()
    {
        playBut.gameObject.SetActive(false);
        PlayerMovement.speed = 10;
        PlayerMovement.xSpeed = 10;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
        restartBut.gameObject.SetActive(false);
        
    }

    public void NextLevelButton()
    {
        SceneManager.LoadScene(0);//next level gelecek
        nextLevelBut.gameObject.SetActive(false);

    }
}
