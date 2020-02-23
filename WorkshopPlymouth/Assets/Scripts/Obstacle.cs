using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage;

    public float xSpeed;

    // Update is called once per frame
    void Update()
    {
        var nextXPosition = transform.position.x + xSpeed;
        var nextYPosition = transform.position.y;

        transform.position = new Vector2(nextXPosition, nextYPosition);
    }

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        if(otherObject.CompareTag("Player"))
        {
            // Getting the instance of the player object
            var player = otherObject.GetComponent<Player>();

            // decrease its health with the damage the obstacle can deal
            player.health -= damage;

            // Print the player's health in the log
            Debug.Log(player.health);

            // gameObject is the instance of the obstacle that collides with the player
            Destroy(gameObject);
        }
    }
}
