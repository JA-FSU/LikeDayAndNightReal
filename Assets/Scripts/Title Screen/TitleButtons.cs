using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour
{
    private Button startButton;
    private Button quitButton;
    private Button creditsButton;
    public GameObject titleText;
    public GameObject creditsText;
    public bool credits = false;

    // Start is called before the first frame update
    void Start()
    {
        startButton = GameObject.Find("StartButton").GetComponent<Button>();
        quitButton = GameObject.Find("QuitButton").GetComponent<Button>();
        creditsButton = GameObject.Find("CreditsButton").GetComponent<Button>();

        startButton.onClick.AddListener(StartGame);
        quitButton.onClick.AddListener(QuitGame);
        creditsButton.onClick.AddListener(Credits);

        startButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
        titleText.SetActive(true);
        creditsText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        Cursor.visible = false;
        SceneManager.LoadScene("Level 1");
    }

    void QuitGame()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }

    void Credits()
    {
        if (!credits)
        {
            startButton.gameObject.SetActive(false);
            quitButton.gameObject.SetActive(false);
            titleText.SetActive(false);
            creditsText.SetActive(true);
            credits = true;
        }
        else
        {
            startButton.gameObject.SetActive(true);
            quitButton.gameObject.SetActive(true);
            titleText.SetActive(true);
            creditsText.SetActive(false);
            credits = false;
        }
    }
}
