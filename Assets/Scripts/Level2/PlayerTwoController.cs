using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerTwoController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public GameObject gameOverText;
    public Button restartButton;

    public float jumpForce = 3;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;

        restartButton.onClick.AddListener(Restart);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        //if (collision.gameObject.CompareTag("Ground"))
        //{
            //isOnGround = true;

        //}
        //else if (collision.gameObject.CompareTag("Obstacle"))
        //{
            //if (gameOver == false)
            //{
                //Destroy(collision.gameobject);
                //gameOver = true;
                //Debug.Log("Game Over!");
            //}
        //}
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (gameOver == false)
            {
                gameOver = true;
                Debug.Log("Game Over!");
                gameOverText.SetActive(true);
                restartButton.gameObject.SetActive(true);
            }
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
