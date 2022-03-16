using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Button playBut;
    public static Button restartBut;
    public static Button nextLevelBut;

    public static GameManager Instance { get; private set; }


    private void Awake()
    {

        ButtonReference();
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

    void ButtonReference()
    {
        playBut = transform.GetChild(0).GetComponent<Button>();
        restartBut = transform.GetChild(1).GetComponent<Button>();
        nextLevelBut = transform.GetChild(2).GetComponent<Button>();
    }
}
