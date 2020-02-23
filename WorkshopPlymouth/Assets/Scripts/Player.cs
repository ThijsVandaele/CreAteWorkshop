using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;

    public int yIncrement;
    public int xIncrement;

    // Update is called once per frame
    void Update()
    {
        var isDownArrowPressed = Input.GetKeyDown(KeyCode.DownArrow);
        var isUpArrowPressed = Input.GetKeyDown(KeyCode.UpArrow);

        if (isDownArrowPressed)
        {
            var nextXPosition = transform.position.x;
            var nextYPosition = transform.position.y - yIncrement;

            transform.position = new Vector2(nextXPosition, nextYPosition);
        }
        else if (isUpArrowPressed)
        {
            var nextXPosition = transform.position.x;
            var nextYPosition = transform.position.y + yIncrement;

            transform.position = new Vector2(nextXPosition, nextYPosition);
        }
    }
}
