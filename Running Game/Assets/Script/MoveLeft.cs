using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10;

    //calling PlayerControllerScript so this script can communicate with PlayerControllerScript
    private PlayerControllerScript playerControllerScript;

    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        //make variable playerControllerScript so we can use it in if else statement
        playerControllerScript = GameObject.Find("player").GetComponent<PlayerControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * if the value of gamOver value is false which from PlayerControllerScript
         * the object will going left else it will stop which over the game
         */
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        /*
         * if the game object with tag "Obstacle" have position less than left bound 
         * will be automatically destroyed
         */
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) 
        { 
            Destroy(gameObject);
        }
            
    }
}
