using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector2 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        // Set startPos to current position and repeatWidth to half the length
        startPos = transform.position;
        repeatWidth = transform.localScale.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // When the x position has moved equal to half the length of the object, reset it back to startPos
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
