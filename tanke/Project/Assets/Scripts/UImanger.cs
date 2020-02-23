using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanger : MonoBehaviour
{
    public GameObject playUI;
    public GameObject pauseUI;
    public Transform player1;
    public Transform player2;
    public GameObject endUI;
    public GameObject winText;
    string a1 = "PLAYER1";
    string a2 = "PLAYER2";
    string b = "WIN";
    string c = "DRAW";
    private bool pauseFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        playUI.SetActive(true);
        pauseUI.SetActive(false);
        endUI.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (player1 == null || player2 == null)
        {
            endUI.SetActive(true);
            if (player1 == null)
                winText.gameObject.GetComponent<Text>().text = "<color=red>" + a2 + "</color>" + b;
            else if (player2 == null)
                winText.gameObject.GetComponent<Text>().text = "<color=green>" + a1 + "</color>" + b;
            else winText.gameObject.GetComponent<Text>().text = c;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && pauseFlag == false)
        {
            PauseGame();
        }

    }
    public void Play()
    {
        playUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Continue()
    {
        pauseUI.SetActive(false);
        pauseFlag = false;
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    void PauseGame()
    {
        pauseUI.SetActive(true);
        pauseFlag = true;
        Time.timeScale = 0;
    }
}
