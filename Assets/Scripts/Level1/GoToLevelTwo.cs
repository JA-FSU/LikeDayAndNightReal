using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevelTwo : MonoBehaviour
{
    [SerializeField] Dialogue dialogue;

    public bool worked = false;

    private void Awake()
    {
        
    }

    public void ToLevelTwo()
    {

        StartCoroutine(DialogueManager.Instance.ShowDialogue(dialogue, () => 
        {
            worked = true;
            Debug.Log("Teleport");
            SceneManager.LoadScene("Level 2");
        }));

        Debug.Log("Done");
    }
}
