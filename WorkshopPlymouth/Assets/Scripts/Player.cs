using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health;

    public int yIncrement;
    public int xIncrement;

    public Text healthDisplay;

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        healthDisplay.text = health.ToString();
               
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
