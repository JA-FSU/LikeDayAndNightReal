using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { FreeRoam, Dialogue }

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerMove playerMove;
    
    GameState state;

    // Start is called before the first frame update
    void Start()
    {
        DialogueManager.Instance.OnShowDialogue += () =>
        {
            state = GameState.Dialogue;
        };

        DialogueManager.Instance.OnCloseDialogue += () =>
        {
            if (state == GameState.Dialogue)
                state = GameState.FreeRoam;
        };
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

        if (state == GameState.FreeRoam)
        {
            playerMove.HandleUpdate();
        }
        else if (state == GameState.Dialogue)
        {
            DialogueManager.Instance.HandleUpdate();
        }
    }
}
