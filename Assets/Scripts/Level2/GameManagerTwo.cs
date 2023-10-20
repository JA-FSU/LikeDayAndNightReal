using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerTwo : MonoBehaviour
{
    PlayerTwoController playerTwo;
    public TextMeshProUGUI timerText;

    private float time = 70.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerTwo = GameObject.Find("Player").GetComponent<PlayerTwoController>();
        timerText.text = "Timer: " + time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            Cursor.visible = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            Cursor.visible = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quitting...");
            Application.Quit();
        }

        if (!playerTwo.gameOver && time > 0)
        {
            time -= Time.deltaTime;
            timerText.text = "Timer: " + Mathf.Round(time);
            if (time <= 0)
            {
                SceneManager.LoadScene("Title Screen");
            }
        }
    }
}
