using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour, Interactable
{
    [SerializeField] Dialogue dialogue;

    NPCState state;

    public void Interact()
    {
        if (state == NPCState.Idle)
        {
            state = NPCState.Dialogue;
            StartCoroutine(DialogueManager.Instance.ShowDialogue(dialogue, () =>
            {
                state = NPCState.Idle;
            }));
        }
    }
}

public enum NPCState { Idle, Dialogue }